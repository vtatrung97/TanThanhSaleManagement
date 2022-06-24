using System.Threading.Tasks;
using Abp.Domain.Uow;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Delta.SaleProject.Authorization.Delegation;
using Delta.SaleProject.Authorization.Users.Delegation;
using Delta.SaleProject.Web.Areas.App.Models.Layout;
using Delta.SaleProject.Web.Views;

namespace Delta.SaleProject.Web.Areas.App.Views.Shared.Components.
    AppActiveUserDelegationsCombobox
{
    public class AppActiveUserDelegationsComboboxViewComponent : SaleProjectViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public AppActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService,
            IUserDelegationConfiguration userDelegationConfiguration,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            return await _unitOfWorkManager.WithUnitOfWorkAsync(async () =>
            {
                var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
                var model = new ActiveUserDelegationsComboboxViewModel
                {
                    UserDelegations = activeUserDelegations,
                    UserDelegationConfiguration = _userDelegationConfiguration
                };

                return View(model);
            });
        }
    }
}
