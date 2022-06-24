using Abp.Events.Bus;

namespace Delta.SaleProject.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}