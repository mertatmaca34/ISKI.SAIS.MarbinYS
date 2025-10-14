using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisDiagnosticClient
{
    Task<IReadOnlyCollection<DiagnosticTypeResponse>> GetDiagnosticTypesAsync(CancellationToken cancellationToken);

    Task SendDiagnosticAsync(SendDiagnosticRequest request, CancellationToken cancellationToken);

    Task SendDiagnosticAsync(SendDiagnosticWithTypeRequest request, CancellationToken cancellationToken);

    Task SendPowerOffNotificationAsync(PowerOffNotificationRequest request, CancellationToken cancellationToken);
}
