using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minx.Razor.Services
{
    public class LoadingScreenService
    {
        private bool loading = false;

        public bool Loading => loading;

        public event Action OnShow;

        public event Action OnClose;

        public void SetAsLoading()
        {
            // loading = true;
            // if (contentType.BaseType != typeof(ComponentBase))
            //    throw new ArgumentException($"{contentType.FullName} must be a Blazor Component");
            // var content = new RenderFragment(x => { x.OpenComponent(1, contentType); x.CloseComponent(); });
            OnShow?.Invoke();
        }

        public void SetAsLoaded()
        {
            // loading = false;
            OnClose?.Invoke();
        }
    }
}