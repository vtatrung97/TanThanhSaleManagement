using Delta.SaleProject.Models.Tenants;
using Delta.SaleProject.ViewModels;
using Xamarin.Forms;

namespace Delta.SaleProject.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}