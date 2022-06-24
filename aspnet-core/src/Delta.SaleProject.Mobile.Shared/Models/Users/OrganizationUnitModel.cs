using Abp.AutoMapper;
using Delta.SaleProject.Organizations.Dto;

namespace Delta.SaleProject.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}