using Delta.SaleProject.Editions;
using Delta.SaleProject.Editions.Dto;
using Delta.SaleProject.MultiTenancy.Payments;
using Delta.SaleProject.Security;
using Delta.SaleProject.MultiTenancy.Payments.Dto;

namespace Delta.SaleProject.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
