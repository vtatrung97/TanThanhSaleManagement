using Abp.AutoMapper;
using Delta.SaleProject.Authorization.Users;
using Delta.SaleProject.Authorization.Users.Dto;
using Delta.SaleProject.Web.Areas.App.Models.Common;

namespace Delta.SaleProject.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}