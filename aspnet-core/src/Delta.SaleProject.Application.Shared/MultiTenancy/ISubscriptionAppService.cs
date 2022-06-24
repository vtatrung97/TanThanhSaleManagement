using System.Threading.Tasks;
using Abp.Application.Services;

namespace Delta.SaleProject.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
