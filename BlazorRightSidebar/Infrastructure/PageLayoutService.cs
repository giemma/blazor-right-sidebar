using Microsoft.AspNetCore.Components;

namespace BlazorRightSidebar.Infrastructure
{
    public class PageLayoutService
    {
        public event Action OnChange;
        private RenderFragment barContent;
        public RenderFragment BarContent
        {
            get
            {
                return barContent;
            }
            set
            {

                barContent = value;
                NotifyStateChanged();
            }
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
