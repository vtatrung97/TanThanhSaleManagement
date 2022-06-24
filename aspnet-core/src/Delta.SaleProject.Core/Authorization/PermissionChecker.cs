using Abp.Authorization;
using Delta.SaleProject.Authorization.Roles;
using Delta.SaleProject.Authorization.Users;

namespace Delta.SaleProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
