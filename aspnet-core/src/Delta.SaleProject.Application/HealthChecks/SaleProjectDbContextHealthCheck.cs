using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Delta.SaleProject.EntityFrameworkCore;

namespace Delta.SaleProject.HealthChecks
{
    public class SaleProjectDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public SaleProjectDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("SaleProjectDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("SaleProjectDbContext could not connect to database"));
        }
    }
}
