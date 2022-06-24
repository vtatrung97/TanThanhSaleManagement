using System.Collections.Generic;
using Delta.SaleProject.Authorization.Permissions.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}