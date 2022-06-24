using System.ComponentModel.DataAnnotations;

namespace Delta.SaleProject.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}