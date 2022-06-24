using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Areas.App.Models.Layout;
using Delta.SaleProject.Web.Session;
using Delta.SaleProject.Web.Views;

namespace Delta.SaleProject.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : SaleProjectViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
