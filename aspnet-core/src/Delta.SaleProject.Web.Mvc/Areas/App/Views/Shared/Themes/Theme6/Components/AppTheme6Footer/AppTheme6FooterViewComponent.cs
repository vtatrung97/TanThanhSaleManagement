using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Areas.App.Models.Layout;
using Delta.SaleProject.Web.Session;
using Delta.SaleProject.Web.Views;

namespace Delta.SaleProject.Web.Areas.App.Views.Shared.Themes.Theme6.Components.AppTheme6Footer
{
    public class AppTheme6FooterViewComponent : SaleProjectViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme6FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
