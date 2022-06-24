using Abp.AutoMapper;
using Delta.SaleProject.MultiTenancy;
using Delta.SaleProject.MultiTenancy.Dto;
using Delta.SaleProject.Web.Areas.App.Models.Common;

namespace Delta.SaleProject.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}