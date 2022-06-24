using System.Threading.Tasks;
using Abp.Webhooks;

namespace Delta.SaleProject.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
