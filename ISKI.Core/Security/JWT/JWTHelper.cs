using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ISKI.Core.Security.Entities;

namespace ISKI.Core.Security.JWT;

public class JwtHelper(IConfiguration configuration)
{
    private readonly TokenOptions _tokenOptions = configuration.GetSection("TokenOptions").Get<TokenOptions>()
                        ?? throw new Exception("TokenOptions bulunamadı!");

    public AccessToken CreateAccessToken(User user, IList<OperationClaim> operationClaims)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        var expiration = DateTime.UtcNow.AddMinutes(_tokenOptions.AccessTokenExpiration);

        var jwt = new JwtSecurityToken(
            issuer: _tokenOptions.Issuer,
            audience: _tokenOptions.Audience,
            expires: expiration,
            notBefore: DateTime.UtcNow,
            claims: SetClaims(user, operationClaims),
            signingCredentials: credentials
        );

        var token = new JwtSecurityTokenHandler().WriteToken(jwt);

        return new AccessToken
        {
            Token = token,
            Expiration = expiration
        };
    }

    private static List<Claim> SetClaims(User user, IList<OperationClaim> operationClaims)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            new(ClaimTypes.Email, user.Email),
        };

        claims.AddRange(operationClaims.Select(c => new Claim(ClaimTypes.Role, c.Name)));

        return claims;
    }
}
