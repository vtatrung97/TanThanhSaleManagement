using Abp.AutoMapper;
using Delta.SaleProject.Authorization.Roles.Dto;
using Delta.SaleProject.Web.Areas.App.Models.Common;

namespace Delta.SaleProject.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}