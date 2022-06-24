using System.Collections.Generic;
using Delta.SaleProject.Editions.Dto;
using Delta.SaleProject.MultiTenancy.Payments;

namespace Delta.SaleProject.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}