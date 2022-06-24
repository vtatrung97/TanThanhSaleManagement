using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Session;

namespace Delta.SaleProject.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : SaleProjectViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string skin)
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo, skin));
        }
    }
}
