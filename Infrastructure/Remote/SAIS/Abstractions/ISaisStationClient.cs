using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisStationClient
{
    Task<StationInformationResponse> GetStationInformationAsync(Guid stationId, CancellationToken cancellationToken);

    Task UpdateStationHostAsync(StationHostUpdateRequest request, CancellationToken cancellationToken);
}
