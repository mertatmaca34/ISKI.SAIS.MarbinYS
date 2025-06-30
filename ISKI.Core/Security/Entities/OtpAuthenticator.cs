namespace ISKI.Core.Security.Entities;

public class OtpAuthenticator
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public byte[] SecretKey { get; set; }

    // Navigation
    public User User { get; set; }
}
