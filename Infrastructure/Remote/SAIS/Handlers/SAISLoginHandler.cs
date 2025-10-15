using Infrastructure.Remote.SAIS.Exceptions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Remote.SAIS.Handlers;

internal sealed record Up_LoginUser(string username, string password);
internal sealed record Up_LoginObjects(string TicketId /*, diğer alanlar gerekirse eklenir */);
internal sealed record Up_ResultStatus<T>(bool result, string? message, T? objects);

public sealed class SAISLoginHandler : DelegatingHandler
{
    private readonly SAISOptions _opt;
    private readonly ILogger<SAISLoginHandler> _log;
    private readonly SemaphoreSlim _gate = new(1, 1);

    private string? _ticket;
    private DateTimeOffset _ticketExpUtc;

    public SAISLoginHandler(IOptions<SAISOptions> opt, ILogger<SAISLoginHandler> log)
    {
        _opt = opt.Value;
        _log = log;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
    {
        // 1) Ticket yok/expired → login
        if (!HasValidTicket())
        {
            await EnsureLoginAsync(ct);
        }

        // 2) Header’a JSON serialize edilmiş TicketId’yi koy
        AttachTicketHeader(request);

        // 3) Gönder
        var response = await base.SendAsync(request, ct);

        // 4) 401 ise → bir kez login yenile ve tekrar dene
        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            response.Dispose(); // body tüketilmeden yeniden denemek için

            _log.LogWarning("SAIS 401 aldı; ticket yenileniyor ve istek tekrar gönderilecek…");
            await EnsureLoginAsync(ct);

            var retry = request.Clone(); // aynı isteği tekrar oluştur
            AttachTicketHeader(retry);
            response = await base.SendAsync(retry, ct);
        }

        return response;
    }

    private bool HasValidTicket()
        => !string.IsNullOrWhiteSpace(_ticket) && DateTimeOffset.UtcNow < _ticketExpUtc;

    private async Task EnsureLoginAsync(CancellationToken ct)
    {
        await _gate.WaitAsync(ct);
        try
        {
            if (HasValidTicket()) return; // double-check

            using var http = new HttpClient
            {
                BaseAddress = new Uri(_opt.BaseUrl),
                Timeout = _opt.Timeout
            };

            var body = new Up_LoginUser(_opt.Username, DoubleMd5(_opt.Password));
            var resp = await http.PostAsJsonAsync(_opt.LoginUrl, body, ct);
            var env = await resp.Content.ReadFromJsonAsync<Up_ResultStatus<Up_LoginObjects>>(cancellationToken: ct);

            if (!resp.IsSuccessStatusCode || env is null || !env.result || env.objects is null || string.IsNullOrWhiteSpace(env.objects.TicketId))
            {
                var msg = env?.message ?? "Login failed";
                throw new SAISRemoteException((int)resp.StatusCode, msg);
            }

            _ticket = env.objects.TicketId;
            _ticketExpUtc = DateTimeOffset.UtcNow.Add(_opt.TicketTtl);

            _log.LogInformation("SAIS login başarılı, TicketId alındı.");
        }
        finally
        {
            _gate.Release();
        }
    }

    private void AttachTicketHeader(HttpRequestMessage req)
    {
        // Doküman: header’a JSON-serialize “{ TicketId = \"GUID\" }” eklenecek.
        // Pratikte çoğu entegrasyonda header değeri JSON-stringtir.
        // Anahtar adı _opt.TicketHeaderName (default: "AToken")
        if (!string.IsNullOrWhiteSpace(_ticket))
        {
            var json = $"{{ \"TicketId\": \"{_ticket}\" }}";
            req.Headers.Remove(_opt.TicketHeaderName);
            req.Headers.TryAddWithoutValidation(_opt.TicketHeaderName, json);
        }
    }

    private static string DoubleMd5(string input)
    {
        static string Md5Hex(string s)
        {
            using var md5 = MD5.Create();
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            var sb = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
        return Md5Hex(Md5Hex(input));
    }
}

// === Request clone helper ===
// HttpContent tekrar okunamaz; basit JSON/Query ağırlıklı çağrılarda iş görür.
// İleri seviye senaryoda özel clone’lama gerekebilir.
internal static class HttpRequestMessageExtensions
{
    public static HttpRequestMessage Clone(this HttpRequestMessage req)
    {
        var clone = new HttpRequestMessage(req.Method, req.RequestUri);
        // headers
        foreach (var h in req.Headers)
            clone.Headers.TryAddWithoutValidation(h.Key, h.Value);

        // content
        if (req.Content is not null)
        {
            Stream ms = new MemoryStream();
            req.Content.CopyToAsync(ms, null);
            ms.Position = 0;
            var newContent = new StreamContent(ms);
            foreach (var h in req.Content.Headers)
                newContent.Headers.TryAddWithoutValidation(h.Key, h.Value);
            clone.Content = newContent;
        }

        clone.Version = req.Version;
        return clone;
    }
}
