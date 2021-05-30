using Microsoft.AspNetCore.Components;

namespace Minx.Razor.Models
{
    public class HeaderButton
    {
        private readonly string icon;
        private readonly EventCallback callback;

        public string Icon => icon;
        public EventCallback Callback => callback;

        public HeaderButton(string icon, EventCallback callback)
        {
            this.icon = icon;
            this.callback = callback;
        }
    }
}