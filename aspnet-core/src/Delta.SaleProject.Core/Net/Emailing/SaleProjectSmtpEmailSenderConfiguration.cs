using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace Delta.SaleProject.Net.Emailing
{
    public class SaleProjectSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public SaleProjectSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}