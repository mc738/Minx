using Microsoft.AspNetCore.Components;
using System;
using Minx.Razor.Services;

namespace Minx.Razor.Components
{
    public class LoadingScreenBase
        : ComponentBase, IDisposable
    {
        [Inject] LoadingScreenService LoadingService { get; set; }

        protected bool IsVisible { get; set; }
        protected string Title { get; set; }
        protected RenderFragment Content { get; set; }

        // public ModalBase()
        // {
        //     ModalService.OnShow += ShowModal;
        //     ModalService.OnClose += CloseModal;
        // }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            LoadingService.OnShow += Show;
            LoadingService.OnClose += Close;
        }

        public async void Show()
        {
            IsVisible = true;

            await InvokeAsync(() => StateHasChanged());
        }

        public async void Close()
        {
            IsVisible = false;

            await InvokeAsync(() => StateHasChanged());
        }

        public void Dispose()
        {
            LoadingService.OnShow -= Show;
            LoadingService.OnClose -= Close;
        }
    }
}