using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Delta.SaleProject.WebHooks.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
