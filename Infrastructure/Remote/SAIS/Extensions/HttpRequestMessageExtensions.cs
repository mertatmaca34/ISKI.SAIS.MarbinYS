namespace Infrastructure.Remote.SAIS.Extensions;

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
