// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Server.Pages.Khachhang
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/khachhangdialog/{id}")]
    public partial class Khachhandetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
       
    [Parameter]
    public string id { get; set; }

    public IJSRuntime JSRuntime { get; set; }

    Khachhang khachhang = new Khachhang();

    protected override void OnInitialized()
    {
        khachhang = _khachhangSvc.GetKhachhang(int.Parse(id));
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("khachhangList", true);
    }

    public void Delete()
    {
        _khachhangSvc.DeleteKhachHang(int.Parse(id));
        NavigationManager.NavigateTo("khachhangList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.IKhachhangSvc _khachhangSvc { get; set; }
    }
}
#pragma warning restore 1591
