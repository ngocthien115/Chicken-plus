#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be0da6501eb5cb2feb938b965efdfc610f89344"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group flex-nowrap");
            __builder.AddMarkupContent(3, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "E-mail");
            __builder.AddAttribute(8, "aria-label", "email");
            __builder.AddAttribute(9, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
                                                         email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "input-group flex-nowrap");
            __builder.AddMarkupContent(15, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", "E-mail");
            __builder.AddAttribute(20, "aria-label", "email");
            __builder.AddAttribute(21, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
                                                         password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Login.razor"
                                              CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "Đăng nhập");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591