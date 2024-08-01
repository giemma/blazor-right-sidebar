using BlazorRightSidebar.Infrastructure;
using Microsoft.AspNetCore.Components;

namespace BlazorRightSidebar.Components.Layout
{
    public partial class RightSiderbarContent
    {
        [CascadingParameter]
        public PageLayoutService PageLayoutService { get; set; }

        [Parameter]
        public RenderFragment BarContent { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
        protected override async Task OnInitializedAsync()
        {
            PageLayoutService.BarContent = BarContent;
            StateHasChanged();
        }
    }
}