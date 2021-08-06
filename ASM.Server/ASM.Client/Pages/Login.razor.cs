using ASM.Share.Models;
using ASM.Share.Models.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ASM.Client.Pages
{
    public partial class Login
    {
        private bool loading;
        private string error;

        string email = "";
        string password = "";

        private string name;
        protected override void OnInitialized()
        {
            
        }
        private string Encode(string param)
        {
            return HttpUtility.UrlEncode(param);
        }

        public void Enter(KeyboardEventArgs e)
        {
            if (e.Code == "Enter" || e.Code == "NumpadEnter")
            {
                if (password != "")
                {
                    CheckLogin();
                }
            }
        }
        private async Task CheckLogin()
        {
            error = "";
            if (email == "")
            {
                error = "Bạn cần nhập email.";
            }
            if (password == "")
            {
                error = "Bạn cần nhập mật khẩu";
            }
            if (error == "")
            {
                var apiUrl = config.GetSection("API")["APIUrl"].ToString();
                using (var client = new HttpClient())
                {
                    ViewWebLogin viewWebLogin = new ViewWebLogin() { Email = email, Password = password };
                    client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                    StringContent content = new StringContent(JsonConvert.SerializeObject(viewWebLogin), System.Text.Encoding.UTF8,"application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl + "Token", content);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        error += (error == "" ? "" : "<br/>") + " - Lỗi khi gọi API.";
                    }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var viewToken = JsonConvert.DeserializeObject<ViewToken>(apiResponse);
                        var accessToken = viewToken.Token;
                        sessionStorage.SetItem("KhachhangId", viewToken.KhachhangId);
                        sessionStorage.SetItem("Email", email);
                        sessionStorage.SetItem("AccessToken", viewToken.Token);

                        //await JSRuntime.InvokeAsync<object>("refreshMenu", new { email = email });
                        NavigationManager.NavigateTo("/", true);
                    }
                }
            }
        }
    }
}
