using System.Collections.Generic;
using Delta.SaleProject.Authorization.Delegation;
using Delta.SaleProject.Authorization.Users.Delegation.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
