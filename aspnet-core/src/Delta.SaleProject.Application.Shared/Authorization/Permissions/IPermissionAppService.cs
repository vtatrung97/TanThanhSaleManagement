using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Authorization.Permissions.Dto;

namespace Delta.SaleProject.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
