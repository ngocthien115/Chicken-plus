#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b145ffe70fe117cc00171f44d18435867c3c33f3"
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
#line 12 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/donhangchitiet/{id}")]
    public partial class DetailsOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
 if (details == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading ...</p>");
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>ĐƠN HÀNG CHI TIẾT</h3>\r\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table mt-3 text-center");
            __builder.AddMarkupContent(4, @"<thead class=""thead-light""><tr><th scope=""col"">Tên món ăn</th>
                <th scope=""col"">Hình</th>
                <th scope=""col"">Giá</th>
                <th scope=""col"">Số lượng</th>
                <th scope=""col"">Thành tiền</th>
                <th scope=""col""></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
             foreach (var item in details)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                     item.donhang.KhachhangID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                     item.monan.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                  
                    temp = imgUrl + item.monan.Hinh;
                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 33 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                               temp

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "style", "width:100px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                     item.monan.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                     item.donhangchitiet.Soluong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 36 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
                     item.donhangchitiet.Thanhtien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\DetailsOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591