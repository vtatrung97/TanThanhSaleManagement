using Abp.AspNetCore.Mvc.Views;

namespace Delta.SaleProject.Web.Views
{
    public abstract class SaleProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected SaleProjectRazorPage()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}
