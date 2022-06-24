using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Web.Areas.App.Models.Layout;
using Delta.SaleProject.Web.Views;

namespace Delta.SaleProject.Web.Areas.App.Views.Shared.Components.AppLanguageSwitch
{
    public class AppLanguageSwitchViewComponent : SaleProjectViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
