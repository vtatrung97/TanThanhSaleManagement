using System.Collections.Generic;
using Delta.SaleProject.Authorization.Permissions.Dto;

namespace Delta.SaleProject.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}