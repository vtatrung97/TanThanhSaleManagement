using System.Threading.Tasks;

namespace Delta.SaleProject.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}