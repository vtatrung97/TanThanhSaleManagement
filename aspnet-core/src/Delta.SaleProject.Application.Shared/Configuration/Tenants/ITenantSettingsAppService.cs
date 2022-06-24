using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.Configuration.Tenants.Dto;

namespace Delta.SaleProject.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
