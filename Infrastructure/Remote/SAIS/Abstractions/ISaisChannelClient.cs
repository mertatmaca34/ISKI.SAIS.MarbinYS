using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisChannelClient
{
    Task<IReadOnlyCollection<ChannelInformationResponse>> GetChannelsAsync(Guid stationId, CancellationToken cancellationToken);

    Task UpdateChannelAsync(ChannelUpdateRequest request, CancellationToken cancellationToken);
}
