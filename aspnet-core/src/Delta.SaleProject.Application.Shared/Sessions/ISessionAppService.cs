using System.Threading.Tasks;
using Abp.Application.Services;
using Delta.SaleProject.Sessions.Dto;

namespace Delta.SaleProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
