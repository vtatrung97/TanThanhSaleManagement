using System.Threading.Tasks;
using Delta.SaleProject.Authorization.Users;

namespace Delta.SaleProject.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
