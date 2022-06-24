using System.Collections.Generic;
using Delta.SaleProject.DynamicEntityProperties.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
