using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Delta.SaleProject.Authorization.Permissions.Dto;
using Delta.SaleProject.Web.Areas.App.Models.Common;

namespace Delta.SaleProject.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}