using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisGeneralInformationClient
{
    Task<IReadOnlyCollection<ParameterInformationResponse>> GetParametersAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<UnitInformationResponse>> GetUnitsAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<DataStatusResponse>> GetDataStatusesAsync(CancellationToken cancellationToken);
}
