using System.Security.Claims;

namespace ISKI.Core.Security.Extensions;

public static class ClaimExtensions
{
    public static Guid GetUserId(this IEnumerable<Claim> claims)
    {
        return Guid.Parse(claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value
                          ?? throw new Exception("UserId bulunamadı."));
    }

    public static string GetEmail(this IEnumerable<Claim> claims)
    {
        return claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value
               ?? throw new Exception("Email bulunamadı.");
    }

    public static List<string> GetRoles(this IEnumerable<Claim> claims)
    {
        return claims.Where(x => x.Type == ClaimTypes.Role)
                     .Select(x => x.Value)
                     .ToList();
    }

    public static string GetFullName(this IEnumerable<Claim> claims)
    {
        return claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value
               ?? throw new Exception("Full name bulunamadı.");
    }
}
