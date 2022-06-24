using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delta.SaleProject.Authorization.Permissions.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
