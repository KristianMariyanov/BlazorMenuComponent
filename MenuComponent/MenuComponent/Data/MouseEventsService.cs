using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MenuComponent.Data
{
    public class MouseEventsService
    {
        private readonly IJSRuntime jSRuntime;

        public MouseEventsService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task OnMenuMouseOver(string menuId, MouseEventArgs ev)
        {
            await jSRuntime.InvokeVoidAsync("MenuComponent.OnMenuMouseOver", menuId, ev);
        }

        public async Task OnMenuMouseOut(string menuId, MouseEventArgs ev)
        {
            await jSRuntime.InvokeVoidAsync("MenuComponent.OnMenuMouseOut", menuId, ev);
        }
    }
}
