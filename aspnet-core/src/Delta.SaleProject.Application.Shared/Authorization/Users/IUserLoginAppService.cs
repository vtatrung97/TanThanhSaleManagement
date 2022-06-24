using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Authorization.Users.Dto;

namespace Delta.SaleProject.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
