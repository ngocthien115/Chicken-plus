#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b267a99b8af5c8a3184d554785d1aaaa9511139e"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w-75 m-auto");
            __builder.AddMarkupContent(2, "<h3>CHI TIẾT KHÁCH HÀNG</h3>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                      khachhang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "hidden");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                    khachhang.KhachhangID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.KhachhangID = __value, khachhang.KhachhangID));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label>Họ tên</label>\r\n            ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Họ tên");
                __builder2.AddAttribute(20, "disabled");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                                                 khachhang.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.FullName = __value, khachhang.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __Blazor.ASM.Server.Pages.Khachhang.Khachhandetails.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 19 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                      () => khachhang.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label>E-mail</label>\r\n            ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "placeholder", "E-mail");
                __builder2.AddAttribute(34, "disabled");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                                                 khachhang.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.EmailAddress = __value, khachhang.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __Blazor.ASM.Server.Pages.Khachhang.Khachhandetails.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 24 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                      () => khachhang.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label>Ngày sinh</label>\r\n            ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "date");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Ngày sinh");
                __builder2.AddAttribute(48, "disabled");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                                                    khachhang.Ngaysinh

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Ngaysinh = __value, khachhang.Ngaysinh, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __Blazor.ASM.Server.Pages.Khachhang.Khachhandetails.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                      () => khachhang.Ngaysinh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Số điện thoại</label>\r\n            ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "text");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "Số điện thoại");
                __builder2.AddAttribute(62, "disabled");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                                                        khachhang.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.PhoneNumber = __value, khachhang.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.ASM.Server.Pages.Khachhang.Khachhandetails.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 34 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                      () => khachhang.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "type", "button");
                __builder2.AddAttribute(71, "class", "btn btn-info");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "type", "button");
                __builder2.AddAttribute(77, "class", "btn btn-danger");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Khachhang\Khachhandetails.razor"
                                                               Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "value", "Xoá");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
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
namespace __Blazor.ASM.Server.Pages.Khachhang.Khachhandetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591