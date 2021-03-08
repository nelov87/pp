using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using INStudio.Areas.Administration.Shared.Enums;

namespace INStudio.Areas.Administration.Shared
{
    public partial class Textarea : ComponentBase, IDisposable
    {
        [Inject] private IJSRuntime JSRuntime { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public string Value { get; set; }

        [Parameter] public EventCallback<string> ValueChanged { get; set; }

        [Parameter] public string Id { get; set; } = null;

        private DotNetObjectReference<Textarea> _elementRef;

        [Parameter] public MenuModeEnum MenuMode { get; set; } = MenuModeEnum.standard;

        protected string FieldClass => GivenEditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty;

        protected EditContext GivenEditContext { get; set; }

        protected FieldIdentifier FieldIdentifier { get; set; }

        protected string CurrentValue
        {
            get => Value;
            set
            {
                var hasChanged = !EqualityComparer<string>.Default.Equals(value, Value);
                if (!hasChanged) return;

                _ = value;

                Value = value;
                _ = ValueChanged.InvokeAsync(value);
                GivenEditContext?.NotifyFieldChanged(FieldIdentifier);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            this.Id = Id ?? Guid.NewGuid().ToString();
            _elementRef = DotNetObjectReference.Create(this);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("TinyMce.init", Id, Enum.GetName(typeof(MenuModeEnum), MenuMode), _elementRef);
            }
        }

        [JSInvokable("textArea_OnChange")]
        public void Change(string value)
        {
            CurrentValue = value;
        }

        protected virtual void Dispose(bool disposing)
        {
            JSRuntime.InvokeVoidAsync("TinyMce.dispose", Id, _elementRef);
        }

        void IDisposable.Dispose()
        {
            Dispose(disposing: true);
        }


        internal void DismissInstance()
        {
            JSRuntime.InvokeVoidAsync("TinyMce.dispose", Id, _elementRef);
            StateHasChanged();
        }
    }
}