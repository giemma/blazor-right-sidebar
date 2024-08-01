using BlazorRightSidebar.Infrastructure;
using Microsoft.AspNetCore.Components;

namespace BlazorRightSidebar.Components.Layout
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        protected PageLayoutService PageLayoutService { get; set; }

        public bool RightbarVisible { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PageLayoutService.OnChange += PageLayoutService_OnChange;
        }

        public void ToggleRightbar()
        {
            RightbarVisible = !RightbarVisible;
            StateHasChanged();
        }

        private void PageLayoutService_OnChange()
        {
            StateHasChanged();
        }

        public void Dispose()
        {
            PageLayoutService.OnChange += PageLayoutService_OnChange;
        }
    }
}