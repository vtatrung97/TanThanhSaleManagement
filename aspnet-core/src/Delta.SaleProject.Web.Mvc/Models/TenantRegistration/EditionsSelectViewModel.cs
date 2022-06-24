using Abp.AutoMapper;
using Delta.SaleProject.MultiTenancy.Dto;

namespace Delta.SaleProject.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
