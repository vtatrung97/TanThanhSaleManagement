using System.ComponentModel.DataAnnotations;

namespace Delta.SaleProject.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
