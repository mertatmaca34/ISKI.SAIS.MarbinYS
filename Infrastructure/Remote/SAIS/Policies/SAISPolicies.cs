using Polly;
using Polly.Extensions.Http;

namespace Infrastructure.Remote.SAIS.Policies;

public static class SAISPolicies
{
    public static IAsyncPolicy<HttpResponseMessage> Timeout()
        => Policy.TimeoutAsync<HttpResponseMessage>(8);

    public static IAsyncPolicy<HttpResponseMessage> RetryJitter()
        => HttpPolicyExtensions
           .HandleTransientHttpError()
           .OrResult(r => (int)r.StatusCode == 429)
           .WaitAndRetryAsync(3, attempt =>
               TimeSpan.FromMilliseconds(200 * attempt + Random.Shared.Next(0, 100)));

    public static IAsyncPolicy<HttpResponseMessage> CircuitBreaker()
        => HttpPolicyExtensions
           .HandleTransientHttpError()
           .CircuitBreakerAsync(5, TimeSpan.FromSeconds(20));
}
