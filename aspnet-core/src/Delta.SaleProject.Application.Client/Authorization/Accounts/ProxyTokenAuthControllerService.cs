using System.Threading.Tasks;

namespace Delta.SaleProject.Authorization.Accounts
{
    public class ProxyTokenAuthControllerService : ProxyControllerBase
    {
        public async Task SendTwoFactorAuthCode(long userId, string provider)
        {
            await ApiClient
                .PostAsync("api/" + GetEndpoint(nameof(SendTwoFactorAuthCode)), new { UserId = userId, Provider = provider });
        }
    }
}
