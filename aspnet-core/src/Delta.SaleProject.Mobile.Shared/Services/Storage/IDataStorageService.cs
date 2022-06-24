using System.Threading.Tasks;
using Delta.SaleProject.ApiClient;
using Delta.SaleProject.ApiClient.Models;
using Delta.SaleProject.Sessions.Dto;

namespace Delta.SaleProject.Services.Storage
{
    public interface IDataStorageService
    {
        Task StoreAccessTokenAsync(string newAccessToken);

        Task StoreAuthenticateResultAsync(AbpAuthenticateResultModel authenticateResultModel);

        AbpAuthenticateResultModel RetrieveAuthenticateResult();

        TenantInformation RetrieveTenantInfo();

        GetCurrentLoginInformationsOutput RetrieveLoginInfo();

        void ClearSessionPersistance();

        Task StoreLoginInformationAsync(GetCurrentLoginInformationsOutput loginInfo);

        Task StoreTenantInfoAsync(TenantInformation tenantInfo);
    }
}
