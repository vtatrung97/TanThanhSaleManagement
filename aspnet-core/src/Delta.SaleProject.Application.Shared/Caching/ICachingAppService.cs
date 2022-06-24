using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Caching.Dto;

namespace Delta.SaleProject.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
