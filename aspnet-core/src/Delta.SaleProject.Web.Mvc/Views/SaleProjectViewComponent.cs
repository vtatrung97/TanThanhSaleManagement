using Abp.AspNetCore.Mvc.ViewComponents;

namespace Delta.SaleProject.Web.Views
{
    public abstract class SaleProjectViewComponent : AbpViewComponent
    {
        protected SaleProjectViewComponent()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}