﻿using System.Threading.Tasks;
using Delta.SaleProject.Views;
using Xamarin.Forms;

namespace Delta.SaleProject.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
