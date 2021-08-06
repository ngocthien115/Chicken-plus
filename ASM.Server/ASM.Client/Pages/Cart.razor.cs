using ASM.Share.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Client.Pages
{
    public partial class Cart
    {
        private string emailAddress;
        public ASM.Share.Models.Cart giohang;
        private double total = 0;
        protected string imgUrl = "";
        protected string temp = "";

        protected override async Task OnInitializedAsync()
        {
            emailAddress = sessionStorage.GetItem<string>("Email");
            var cart = sessionStorage.GetItem<string>("Cart");

            if (cart == null)
            {
                giohang = new Share.Models.Cart();
            }
            else
            {
                giohang = JsonConvert.DeserializeObject<ASM.Share.Models.Cart>(cart);
            }
            imgUrl = config.GetSection("API")["imgUrl"].ToString();
        }

        private void UpdateCart(CartItem item)
        {
            item.Sotien = item.Quantity * item.MonAn.Gia;
            giohang.Tongtien = TinhTien(giohang.ListViewCart);
            sessionStorage.SetItem("Cart", JsonConvert.SerializeObject(giohang));
        }
        
        private void DeleteCart(CartItem item)
        {
            giohang.ListViewCart.Remove(item);
            giohang.Tongtien = TinhTien(giohang.ListViewCart);
            sessionStorage.SetItem("Cart", JsonConvert.SerializeObject(giohang));
        }
        
        private async Task OrderCart()
        {
        //    var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        //    imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        //    var khachhangId = sessionStorage.GetItem<string>("KhachhangId");
        //    var token = sessionStorage.GetItem<string>("AccessToken");

        //    giohang.KhanghangId = int.Parse(khachhangId);
        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(giohang), Encoding.UTF8, "application/json");
        //        client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
        //        HttpResponseMessage response = await client.PostAsync(apiUrl + "donhang", content);
        //    }
        }
        private double TinhTien(List<CartItem> listCart)
        {
            double tongien = 0;
            if (listCart != null)
            {
                for (int i = 0; i < listCart.Count; i++)
                {
                    tongien += listCart[i].Sotien;
                }
            }
            return tongien;
        }

    }
}
