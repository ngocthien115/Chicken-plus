#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0dc63ccf24f21d74ea53f926ca3af69fb227765"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search/{loai}")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    * {
        box-sizing: border-box;
    }

    .list-product {
        margin: auto;
        display: flex;
        flex-wrap: wrap;
    }

    .product {
        width: 188px;
        margin: 10px;
    }

    .img-responsive {
        width: 200px;
        height: 150px;
        display: block;
        margin: auto;
    }

    .title {
        color: #0e0e0e;
        display: block;
        font-size: 15px;
        font-weight: bold;
        text-align: center;
        height: 60px;
    }

    .field-price {
        font-size: 24px;
        color: #d50000;
        margin-bottom: 15px;
        font-weight: 700;
        text-align: center;
    }

    .viewProduct, .addProduct {
        border: 0;
        font-weight: 700;
        padding: 9px 5px;
        background: #ffd800;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
        display: block;
        width: 186px;
        margin: 0 auto;
        color: #0e0e0e;
    }
</style>");
#nullable restore
#line 62 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
 if (monans == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"loader-wrapper\"><span class=\"loader\"><span class=\"loader-inner\"></span></span></div>");
#nullable restore
#line 67 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-product");
#nullable restore
#line 71 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
         foreach (var item in monans)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "product");
#nullable restore
#line 74 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                  
                    temp = imgUrl + item.Hinh;
                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "details/" + (
#nullable restore
#line 77 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                  item.MonAnID

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 78 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                               temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "img-responsive");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "title");
            __builder.AddContent(14, 
#nullable restore
#line 79 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "field-price");
            __builder.AddContent(18, 
#nullable restore
#line 80 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                              item.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " VNĐ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "addProduct text-center");
            __builder.AddAttribute(24, "onmouseup", "addCart(" + (
#nullable restore
#line 82 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                                                                         item.MonAnID

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                                                                                                   () => AddCart(item.MonAnID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\r\n                    Add order\r\n                    ");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "id", "imgBusy_" + (
#nullable restore
#line 84 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
                                      item.MonAnID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "src", "images/busy.gif");
            __builder.AddAttribute(30, "style", "display:none");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
