using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Areas.App.Models.Layout;
using Delta.SaleProject.Web.Views;

namespace Delta.SaleProject.Web.Areas.App.Views.Shared.Components.AppRecentNotifications
{
    public class AppRecentNotificationsViewComponent : SaleProjectViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
