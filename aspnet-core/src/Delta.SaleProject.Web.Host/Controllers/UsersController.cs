using Abp.AspNetCore.Mvc.Authorization;
using Delta.SaleProject.Authorization;
using Delta.SaleProject.Storage;
using Abp.BackgroundJobs;

namespace Delta.SaleProject.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}