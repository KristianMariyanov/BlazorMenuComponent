using Microsoft.AspNetCore.Components;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace MenuComponent.Data
{
    /// <summary>
    /// Temp workaround of issues with event bubbling and lacking of stop event propagation in blazor
    /// Blazor feature request: https://github.com/aspnet/AspNetCore/issues/5545
    /// </summary>
    public class ClickEventBubblingResolver
    {
        private static readonly ConcurrentDictionary<string, bool> RestrictedMenuItemEvents = new ConcurrentDictionary<string, bool>();
        public async Task OnClick(string menuId, string parrentMenuId, EventCallback<string> eventCallback)
        {
            if (RestrictedMenuItemEvents.ContainsKey(menuId))
            {
                await TemporaryRestrictEventInvocation(parrentMenuId);
                return;
            }
            else
            {
                await TemporaryRestrictEventInvocation(parrentMenuId);
                await eventCallback.InvokeAsync(menuId);
            }
        }

        private async Task TemporaryRestrictEventInvocation(string parrentMenuId)
        {
            if (parrentMenuId != null)
            {
                if (!RestrictedMenuItemEvents.ContainsKey(parrentMenuId))
                {
                    RestrictedMenuItemEvents.TryAdd(parrentMenuId, true);

                    await Task.Delay(100);

                    RestrictedMenuItemEvents.TryRemove(parrentMenuId, out var _);
                }
            }
        }
    }
}
