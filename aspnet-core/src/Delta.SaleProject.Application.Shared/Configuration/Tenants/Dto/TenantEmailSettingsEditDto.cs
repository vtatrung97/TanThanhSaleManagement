using Abp.Auditing;
using Delta.SaleProject.Configuration.Dto;

namespace Delta.SaleProject.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}