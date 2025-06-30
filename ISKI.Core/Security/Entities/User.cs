using ISKI.Core.Domain;
using ISKI.Core.Security.Enums;

namespace ISKI.Core.Security.Entities;

public class User : BaseEntity<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; } = true;
    public bool AuthenticatorEnabled { get; set; } = false;
    public AuthenticatorType AuthenticatorType { get; set; }

    // Navigation
    public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    public EmailAuthenticator? EmailAuthenticator { get; set; }
    public OtpAuthenticator? OtpAuthenticator { get; set; }
}
