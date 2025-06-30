namespace ISKI.Core.Security.Entities;

public class EmailAuthenticator
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string ActivationKey { get; set; } = string.Empty;
    public bool IsVerified { get; set; }

    // Navigation
    public User User { get; set; }
}
