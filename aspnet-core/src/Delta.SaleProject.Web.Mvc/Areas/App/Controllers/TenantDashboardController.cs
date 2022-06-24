using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Authorization;
using Delta.SaleProject.DashboardCustomization;
using System.Threading.Tasks;
using Delta.SaleProject.Web.Areas.App.Startup;

namespace Delta.SaleProject.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(SaleProjectDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}