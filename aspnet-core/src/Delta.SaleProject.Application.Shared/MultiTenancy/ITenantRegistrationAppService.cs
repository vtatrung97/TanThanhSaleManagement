using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.Editions.Dto;
using Delta.SaleProject.MultiTenancy.Dto;

namespace Delta.SaleProject.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}