#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e575f26e15ece3b39aba9486fc43459032521033"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages
{
    #line hidden
    using System;
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
#line 11 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-i7jnnvtx33");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-i7jnnvtx33");
            __builder.AddMarkupContent(6, "<div class=\"col-lg-3 col-md-2\" b-i7jnnvtx33></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 col-md-8 login-box");
            __builder.AddAttribute(9, "b-i7jnnvtx33");
            __builder.AddMarkupContent(10, "<div class=\"col-lg-12 login-key\" b-i7jnnvtx33><i class=\"fa fa-key\" aria-hidden=\"true\" b-i7jnnvtx33></i></div>\r\n            ");
            __builder.AddMarkupContent(11, "<div class=\"col-lg-12 login-title\" b-i7jnnvtx33>\r\n                QUẢN TRỊ\r\n            </div>\r\n\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-12 login-form");
            __builder.AddAttribute(14, "b-i7jnnvtx33");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-lg-12 login-form");
            __builder.AddAttribute(17, "b-i7jnnvtx33");
            __builder.OpenElement(18, "form");
            __builder.AddAttribute(19, "b-i7jnnvtx33");
            __builder.AddMarkupContent(20, "<input type=\"hidden\" asp-for=\"ReturnUrl\" b-i7jnnvtx33>\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddAttribute(23, "b-i7jnnvtx33");
            __builder.AddMarkupContent(24, "<label class=\"form-control-label\" b-i7jnnvtx33>USERNAME</label>\r\n                            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(30, "b-i7jnnvtx33");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddAttribute(34, "b-i7jnnvtx33");
            __builder.AddMarkupContent(35, "<label class=\"form-control-label\" b-i7jnnvtx33>MẬT KHẨU</label>\r\n                            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "password");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
                                                                                                       Enter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
                                                                                password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(42, "b-i7jnnvtx33");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-lg-12 loginbttm");
            __builder.AddAttribute(46, "b-i7jnnvtx33");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-lg-6 login-btm login-button");
            __builder.AddAttribute(49, "b-i7jnnvtx33");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "submit");
            __builder.AddAttribute(52, "class", "btn btn-outline-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Login.razor"
                                                                                                CheckLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "b-i7jnnvtx33");
            __builder.AddMarkupContent(55, "ĐĂNG NHẬP");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            <div class=\"col-lg-3 col-md-2\" b-i7jnnvtx33></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591