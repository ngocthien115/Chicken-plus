#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9017f4828446245bbec65c8f83598f3d01d02a9b"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Shared
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
    public partial class WebLoginPartial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
 if (emailAddress != null && emailAddress != "")
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""collapse navbar-collapse"" id=""navbarSupportedContent""><a class=""navbar-brand mt-2 mt-lg-0"" href=""/"">
            CHICKEN PLUS
        </a>
        
        <ul class=""navbar-nav me-auto mb-2 mb-lg-0""><li class=""nav-item""><a class=""nav-link"" href=""/history"">Đơn hàng</a></li></ul></div>
    
    
    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex align-items-center");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "text-reset me-3");
            __builder.AddAttribute(5, "href", "/cart");
            __builder.AddMarkupContent(6, "<i class=\"fas fa-shopping-cart\"></i>");
#nullable restore
#line 26 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
             if (cart != null && cart != "")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "class", "badge rounded-pill badge-notification bg-danger");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
                                                                               count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<span class=\"badge rounded-pill badge-notification bg-danger\"></span>");
#nullable restore
#line 33 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(12, @"<a class=""dropdown-toggle d-flex align-items-center hidden-arrow"" id=""navbarDropdownMenuLink"" role=""button"" data-mdb-toggle=""dropdown"" aria-expanded=""false""><img src=""~/images/user-tie.png"" class=""rounded-circle"" height=""25"" alt loading=""lazy""></a>
        ");
            __builder.AddMarkupContent(13, @"<ul class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""navbarDropdownMenuLink""><li><a class=""dropdown-item"" href=""/infomation"">Thông tin</a></li>
            <li><a class=""dropdown-item"" href=""/changepassword"">Đổi mật khẩu</a></li>
            <li><a class=""dropdown-item"" href=""/logout"">Đăng xuất</a></li></ul>");
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\"><a class=\"navbar-brand mt-2 mt-lg-0\" href=\"/\">\r\n           CHICKEN PLUS\r\n        </a></div>\r\n    \r\n    \r\n");
            __builder.AddMarkupContent(15, "<div class=\"d-flex align-items-center\"><a class=\"text-reset me-3\" href=\"/login\"><i class=\"fas fa-sign-in-alt\"></i> Đăng nhập\r\n    </a>\r\n    <a class=\"text-reset me-3\" href=\"/register\"><i class=\"fas fa-user-plus\"></i> Đăng ký\r\n    </a></div>");
#nullable restore
#line 82 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\WebLoginPartial.razor"
      
    string count;
    string emailAddress;
    string cart;
    protected override async Task OnInitializedAsync()
    {
        emailAddress = sessionStorage.GetItem<string>("email");
        cart = sessionStorage.GetItem<string>("cart");
    }

    protected void o()
    {
        emailAddress = sessionStorage.GetItem<string>("email");
        cart = sessionStorage.GetItem<string>("cart");
    }
    protected void Logout()
    {
        sessionStorage.RemoveItem("AccessToken");
        sessionStorage.RemoveItem("Email");
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
