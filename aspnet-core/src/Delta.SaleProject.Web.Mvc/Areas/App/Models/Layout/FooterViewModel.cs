using Delta.SaleProject.Sessions.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Layout
{
    public class FooterViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string GetProductNameWithEdition()
        {
            const string productName = "SaleProject";

            if (LoginInformations.Tenant?.Edition?.DisplayName == null)
            {
                return productName;
            }

            return productName + " " + LoginInformations.Tenant.Edition.DisplayName;
        }
    }

    public class SubheaderViewModel
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}
