// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
            loi = "Mật khẩu mới không trùng khớp!";
            confirmpwd = "";
            await confirm.FocusAsync();
        }
        else
        {
            if (encryptpwd != khachhang.Password && enconfirmpwd != khachhang.ConfirmPassword)
            {
                loi = "Mật khẩu cũ không trùng khớp";
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
                Console.WriteLine("Lỗi khi gọi API");
            }
            else
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (apiResponse == "-1")
                {
                    Console.WriteLine("Thất bại");
                }
                else
                {
                    Console.WriteLine("Thành công");
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
