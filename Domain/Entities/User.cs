using ISKI.Core.Domain;

namespace Domain.Entities;

public class User : BaseEntity<int>
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

