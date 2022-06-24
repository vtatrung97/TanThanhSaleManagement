using Abp.AspNetCore.Mvc.ViewComponents;

namespace Delta.SaleProject.Web.Public.Views
{
    public abstract class SaleProjectViewComponent : AbpViewComponent
    {
        protected SaleProjectViewComponent()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}