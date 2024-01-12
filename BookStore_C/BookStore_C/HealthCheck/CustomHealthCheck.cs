using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStore_C.HealthCheck
{
    public class CustomHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = false;

            // ...

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}

