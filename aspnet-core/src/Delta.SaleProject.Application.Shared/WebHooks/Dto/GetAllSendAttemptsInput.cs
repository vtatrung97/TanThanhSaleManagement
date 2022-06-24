using Delta.SaleProject.Dto;

namespace Delta.SaleProject.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
