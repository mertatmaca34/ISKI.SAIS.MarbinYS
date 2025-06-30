namespace ISKI.Core.Security.JWT;

public class TokenOptions
{
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string SecurityKey { get; set; } = string.Empty;
    public int AccessTokenExpiration { get; set; } // Dakika cinsinden
}
