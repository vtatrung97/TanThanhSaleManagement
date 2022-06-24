using System.Threading.Tasks;
using Delta.SaleProject.Security.Recaptcha;

namespace Delta.SaleProject.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
