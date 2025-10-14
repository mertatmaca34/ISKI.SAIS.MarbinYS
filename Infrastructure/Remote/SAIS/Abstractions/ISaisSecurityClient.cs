namespace Infrastructure.Remote.SAIS;

public interface ISaisSecurityClient
{
    Task<string> LoginAsync(CancellationToken cancellationToken);
}
