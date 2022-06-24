using System.Collections.Generic;
using MvvmHelpers;
using Delta.SaleProject.Models.NavigationMenu;

namespace Delta.SaleProject.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}