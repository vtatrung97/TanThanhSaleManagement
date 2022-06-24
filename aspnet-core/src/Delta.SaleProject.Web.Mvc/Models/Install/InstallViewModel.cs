using System.Collections.Generic;
using Abp.Localization;
using Delta.SaleProject.Install.Dto;

namespace Delta.SaleProject.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
