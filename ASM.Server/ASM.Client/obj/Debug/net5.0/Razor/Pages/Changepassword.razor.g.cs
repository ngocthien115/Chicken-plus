#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3af850aef4d8d4d101fb3485875a97ade4f3b0"
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
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/changepassword/{id}")]
    public partial class Changepassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w-50 m-auto");
            __builder.AddMarkupContent(2, "<h3 class=\"text-center\">?????i m???t kh???u</h3>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "hidden");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 15 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                 khachhang.KhachhangID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "input-group flex-nowrap mt-3");
            __builder.AddMarkupContent(9, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "E-mail");
            __builder.AddAttribute(14, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(15, "readonly");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                                                  email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group flex-nowrap mt-3");
            __builder.AddMarkupContent(21, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "password");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "placeholder", "M???t kh???u c??");
            __builder.AddAttribute(26, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                                         oldpwd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oldpwd = __value, oldpwd));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(29, (__value) => {
#nullable restore
#line 23 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                     mkcu = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "input-group flex-nowrap mt-3");
            __builder.AddMarkupContent(33, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "password");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "placeholder", "M???t kh???u m???i");
            __builder.AddAttribute(38, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                                         newpwd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newpwd = __value, newpwd));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "input-group flex-nowrap mt-3");
            __builder.AddMarkupContent(44, "<span class=\"input-group-text\" id=\"addon-wrapping\"><i class=\"fas fa-user\"></i></span>\r\n        ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "password");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "placeholder", "Nh???p l???i m???t kh???u");
            __builder.AddAttribute(49, "aria-describedby", "addon-wrapping");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                                         confirmpwd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmpwd = __value, confirmpwd));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(52, (__value) => {
#nullable restore
#line 33 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                     confirm = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "alert-danger mt-2");
            __builder.AddContent(56, 
#nullable restore
#line 35 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                        loi

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "mt-3");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "submit");
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
                                                                CheckPass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "X??c nh???n");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Pages\Changepassword.razor"
       
    [Parameter]
    public string id { get; set; }
    private string oldpwd { get; set; }
    private string newpwd { get; set; }
    private string confirmpwd { get; set; }
    private string email { get; set; }
    ElementReference confirm;
    ElementReference mkcu;
    string loi;
    Khachhang khachhang = new Khachhang();
    string apiUrl;

    protected override async Task OnInitializedAsync()
    {
        email = sessionStorage.GetItem<string>("Email");
        apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var strJson = await client.GetStringAsync(apiUrl + "khachhang/" + id);
            khachhang = JsonConvert.DeserializeObject<Khachhang>(strJson);
        }
    }
    private async Task CheckPass()
    {
        string encryptpwd = await JSRuntime.InvokeAsync<string>(identifier: "mahoapwd", oldpwd);
        encryptpwd = encryptpwd.ToUpper();
        string enconfirmpwd = encryptpwd;
        Console.WriteLine(encryptpwd);
        if (confirmpwd != newpwd)
        {
            loi = "M???t kh???u m???i kh??ng tr??ng kh???p!";
            confirmpwd = "";
            await confirm.FocusAsync();
        }
        else
        {
            if (encryptpwd != khachhang.Password && enconfirmpwd != khachhang.ConfirmPassword)
            {
                loi = "M???t kh???u c?? kh??ng tr??ng kh???p";
                oldpwd = "";
                await mkcu.FocusAsync();
            }
            else
            {
                khachhang.Password = newpwd;
                khachhang.ConfirmPassword = confirmpwd;
                await Doipass();
                NavigationManager.NavigateTo("/");
            }
        }
    }

    private async Task Doipass()
    {
        using (HttpClient client = new HttpClient())
        {
            khachhang.Mota = "";
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            StringContent content = new StringContent(JsonConvert.SerializeObject(khachhang), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            HttpResponseMessage response = await client.PutAsync(apiUrl + $"khachhang/{khachhang.KhachhangID}", content);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("L???i khi g???i API");
            }
            else
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (apiResponse == "-1")
                {
                    Console.WriteLine("Th???t b???i");
                }
                else
                {
                    Console.WriteLine("Th??nh c??ng");
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
