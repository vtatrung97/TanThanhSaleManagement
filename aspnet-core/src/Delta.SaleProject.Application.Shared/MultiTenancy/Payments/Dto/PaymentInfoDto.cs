using Delta.SaleProject.Editions.Dto;

namespace Delta.SaleProject.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < SaleProjectConsts.MinimumUpgradePaymentAmount;
        }
    }
}
