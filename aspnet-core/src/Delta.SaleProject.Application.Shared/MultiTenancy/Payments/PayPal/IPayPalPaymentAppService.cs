using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.MultiTenancy.Payments.PayPal.Dto;

namespace Delta.SaleProject.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
