using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Common.Dto;
using Delta.SaleProject.Editions.Dto;

namespace Delta.SaleProject.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}