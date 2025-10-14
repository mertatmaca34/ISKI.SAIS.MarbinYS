namespace Infrastructure.Remote.SAIS;

public sealed class SAISOptions
{
    public string BaseUrl { get; init; } = "https://entegrationsais.csb.gov.tr/";
    public string LoginUrl { get; init; } = "/Security/login"; // dokümandaki uç
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(10);

    // Login
    public string Username { get; init; } = default!;
    public string Password { get; init; } = default!; // düz metin (handler içinde double-MD5’leriz)

    // Ticket yaşam süresi – doküman 30 dk diyor, güvenlik payıyla 29dk kullanırız
    public TimeSpan TicketTtl { get; init; } = TimeSpan.FromMinutes(29);

    // Header adı: Doküman, header’a JSON serialize “{ TicketId = \"GUID\" }” konacağını söylüyor.
    // Saha uygulamalarında genelde bir custom header anahtarı kullanılır. Sunucunun beklediği
    // anahtar “TicketId” ise aşağıdaki default doğru. Farklıysa değiştirebilirsin.
    public string TicketHeaderName { get; init; } = "TicketId";
}
