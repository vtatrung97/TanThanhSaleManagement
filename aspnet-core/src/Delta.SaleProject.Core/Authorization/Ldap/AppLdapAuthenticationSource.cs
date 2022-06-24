using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Delta.SaleProject.Authorization.Users;
using Delta.SaleProject.MultiTenancy;

namespace Delta.SaleProject.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}