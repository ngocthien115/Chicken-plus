#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6a8638e5da50dd5a9dd541843db19f8342edaf"
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
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{id}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        .img-detail {
            width: 100%;
            height: 350px;
        }

        .tensp {
            font-size: 24px;
            margin: 10px 0 40px 0;
        }

        .gia {
            font-size: 18px;
            margin-top: 10px;
            margin-bottom: 20px;
        }

    </style>


");
            __builder.AddMarkupContent(1, "<h3>Details</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "w-75 m-auto mt-5 border border-1 p-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-4");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "img-detail");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 32 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                          imgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-8 p-4 border border-1");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tensp");
            __builder.AddContent(16, 
#nullable restore
#line 35 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                monan.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "phanloai");
            __builder.AddMarkupContent(20, "Loại: ");
            __builder.AddContent(21, 
#nullable restore
#line 36 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                         monan.Phanloai

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "gia");
            __builder.AddMarkupContent(25, "Giá : ");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                    monan.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "control");
            __builder.AddMarkupContent(30, "<button class=\"btn btn-primary\">Mua ngay</button>\r\n                ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-info");
            __builder.AddAttribute(33, "onmouseup", "addCart(" + (
#nullable restore
#line 40 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                                                 monan.MonAnID

#line default
#line hidden
#nullable disable
            ) + ");");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
                                                                                            AddCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "Thêm vào giỏ hàng");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row bottom-field");
            __builder.AddMarkupContent(39, "<hr class=\"mt-4\">\r\n        ");
            __builder.AddMarkupContent(40, "<p class=\"font-italic font-weight-bold\">Mô tả món ăn</p>\r\n        ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, 
#nullable restore
#line 47 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
            monan.Mota

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Details.razor"
       
    [Parameter]
    public string id { get; set; }
    public MonAn monan = new MonAn();
    public List<MonAn> monans;
    string imgUrl;
    protected override async Task OnInitializedAsync()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        monan = await client.GetJsonAsync<MonAn>(apiUrl + "monan/"+ id);
        monans = await client.GetJsonAsync<List<MonAn>>(apiUrl + "monan");
        imgUrl += monan.Hinh;
    }

    private void AddCart()
    {
        var cart = sessionStorage.GetItem<string>("Cart");//get key cart
        if (cart == null)
        {

            var monAn = monans.Where(u => u.MonAnID == monan.MonAnID).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
                {
                    new CartItem
                    {
                        MonAn = monAn,
                        Quantity = 1,
                        Sotien= monAn.Gia
                    }
            };

            ASM.Share.Models.Cart giohang = new ASM.Share.Models.Cart()
            {
                ListViewCart = listCart,
                Tongtien = Tinhtien(listCart)
            };
            sessionStorage.SetItem("Cart", JsonConvert.SerializeObject(giohang));
        }
        else
        {
            var monAn = monans.Where(u => u.MonAnID == monan.MonAnID).FirstOrDefault();

            ASM.Share.Models.Cart giohang = JsonConvert.DeserializeObject<ASM.Share.Models.Cart>(cart);
            bool check = true;
            for (int i = 0; i < giohang.ListViewCart.Count; i++)
            {
                if (giohang.ListViewCart[i].MonAn.MonAnID == monan.MonAnID)
                {
                    giohang.ListViewCart[i].Quantity++;
                    giohang.ListViewCart[i].Sotien = monAn.Gia * giohang.ListViewCart[i].Quantity;
                    check = false;
                }
            }

            if (check)
            {
                giohang.ListViewCart.Add(new CartItem
                {
                    MonAn = monAn,
                    Quantity = 1,
                    Sotien = monAn.Gia * 1
                });
            }
            giohang.Tongtien = Tinhtien(giohang.ListViewCart);
            sessionStorage.SetItem("Cart", JsonConvert.SerializeObject(giohang));
        }
    }

    private double Tinhtien(List<CartItem> listCart)
    {
        double tongtien = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                tongtien += listCart[i].Sotien;
            }
        }
        return tongtien;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
