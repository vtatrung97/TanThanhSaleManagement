using Abp.AutoMapper;
using Delta.SaleProject.MultiTenancy.Dto;

namespace Delta.SaleProject.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}