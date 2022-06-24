using System.Collections.Generic;
using Delta.SaleProject.Editions.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}