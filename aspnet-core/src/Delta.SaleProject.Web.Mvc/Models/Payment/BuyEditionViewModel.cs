using System.Collections.Generic;
using Delta.SaleProject.Editions;
using Delta.SaleProject.Editions.Dto;
using Delta.SaleProject.MultiTenancy.Payments;
using Delta.SaleProject.MultiTenancy.Payments.Dto;

namespace Delta.SaleProject.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
