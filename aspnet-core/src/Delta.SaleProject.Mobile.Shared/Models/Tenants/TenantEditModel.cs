using System.ComponentModel;
using Abp.AutoMapper;
using Delta.SaleProject.MultiTenancy.Dto;

namespace Delta.SaleProject.Models.Tenants
{
    [AutoMapFrom(typeof(TenantEditDto))]
    public class TenantEditModel : TenantEditDto, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}