using Infrastructure.Remote.SAIS.DTOs.Requests;

namespace Infrastructure.Remote.SAIS;

public interface ISaisSampleClient
{
    Task NotifySampleStartAsync(SampleRequestStartRequest request, CancellationToken cancellationToken);

    Task<string> NotifySampleStartForLimitAsync(SampleLimitRequest request, CancellationToken cancellationToken);

    Task CompleteSampleAsync(SampleStatusUpdateRequest request, CancellationToken cancellationToken);

    Task ReportSampleErrorAsync(SampleStatusUpdateRequest request, CancellationToken cancellationToken);
}
