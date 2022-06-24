using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Delta.SaleProject.Web.Public.Views
{
    public abstract class SaleProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SaleProjectRazorPage()
        {
            LocalizationSourceName = SaleProjectConsts.LocalizationSourceName;
        }
    }
}
