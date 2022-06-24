using System.ComponentModel.DataAnnotations;

namespace Delta.SaleProject.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}