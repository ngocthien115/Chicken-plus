using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASM.Server.Pages
{
    public partial class Login
    {
        private string error;

        string username = "";
        string password = "";
        private string Encode(string param)
        {
            return HttpUtility.UrlEncode(param);
        }

        public void Enter(KeyboardEventArgs e)
        {
            if (e.Code == "Enter" || e.Code== "NumpadEnter")
            {
                if (password != "")
                {
                    CheckLogin();
                }
            }
        }
        private void CheckLogin()
        {
            error = "";
            if (username == "" || password == "")
            {
                error = "Sai tên tài khoản hoặc mật khẩu";
            }
            else
            {
                NavigationManager.NavigateTo("CheckLogin?paramUsername=" + @Encode(@username)
                    + "&paramPassword=" + @Encode(@password), true);
            }
        }
    }
}
