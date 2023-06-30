using Microsoft.AspNetCore.Components;

namespace Blazor.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
