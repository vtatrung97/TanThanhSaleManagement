using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace Delta.SaleProject.Localization.Dto
{
    public class SetDefaultLanguageInput
    {
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}