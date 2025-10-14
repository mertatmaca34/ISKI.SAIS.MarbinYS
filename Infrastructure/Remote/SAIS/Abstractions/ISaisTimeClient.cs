namespace Infrastructure.Remote.SAIS;

public interface ISaisTimeClient
{
    Task<DateTimeOffset> GetServerDateTimeAsync(CancellationToken cancellationToken);
}
