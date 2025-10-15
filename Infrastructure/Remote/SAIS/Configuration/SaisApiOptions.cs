namespace Infrastructure.Remote.SAIS.Configuration;

/// <summary>
///     Configuration options required to communicate with the SAİS remote API.
/// </summary>
public sealed class SaisApiOptions
{
    /// <summary>
    ///     Gets or sets the base URL of the remote SAİS API (for example "https://entegrationsais.csb.gov.tr/").
    /// </summary>
    public string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the username that will be used when authenticating against the SAİS API.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the plain text password that will be transformed into the double MD5 hash
    ///     expected by the remote SAİS API during authentication.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the amount of time before ticket expiration when the client should proactively refresh the ticket.
    /// </summary>
    public TimeSpan TicketRenewalOffset { get; set; } = TimeSpan.FromMinutes(5);

    /// <summary>
    ///     Gets or sets the header name that SAİS expects ticket information to be transported in.
    /// </summary>
    public string TicketHeaderName { get; set; } = "AToken";
}
