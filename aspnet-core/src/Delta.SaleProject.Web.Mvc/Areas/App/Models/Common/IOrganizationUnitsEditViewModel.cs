using System.Collections.Generic;
using Delta.SaleProject.Organizations.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}