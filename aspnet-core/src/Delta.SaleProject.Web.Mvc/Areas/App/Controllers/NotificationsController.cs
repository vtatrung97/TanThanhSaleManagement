using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Notifications;
using Delta.SaleProject.Web.Controllers;

namespace Delta.SaleProject.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class NotificationsController : SaleProjectControllerBase
    {
        private readonly INotificationAppService _notificationApp;

        public NotificationsController(INotificationAppService notificationApp)
        {
            _notificationApp = notificationApp;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> SettingsModal()
        {
            var notificationSettings = await _notificationApp.GetNotificationSettings();
            return PartialView("_SettingsModal", notificationSettings);
        }
    }
}