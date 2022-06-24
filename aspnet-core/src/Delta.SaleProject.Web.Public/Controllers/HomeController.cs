using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Controllers;

namespace Delta.SaleProject.Web.Public.Controllers
{
    public class HomeController : SaleProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}