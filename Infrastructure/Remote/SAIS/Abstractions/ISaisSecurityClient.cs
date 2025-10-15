using Infrastructure.Remote.SAIS.Models;

namespace Infrastructure.Remote.SAIS;

public interface ISaisSecurityClient
{
    Task<SaisTicketCredentials> LoginAsync(CancellationToken cancellationToken);
}
