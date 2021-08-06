using ASM.Share.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ASM.Client.Pages
{
    public partial class Index
    {

        protected string imgUrl = "";
        protected string temp = "";
        private string id;
        private string token;
        private string email;


        public List<MonAn> monans;
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
            id = sessionStorage.GetItem<string>("KhachhangId");
            token = sessionStorage.GetItem<string>("AccessToken");
            email = sessionStorage.GetItem<string>("Email");

        }
        protected async Task LoadData()
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();
            //monans = new List<MonAn>();
            //using (var client = new HttpClient())
            //{
            //    //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            //    client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            //    client.BaseAddress = new Uri(apiUrl);
            //    using (var response = await client.GetAsync("MonAn"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        monans = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
            //    }
            //}
            monans = await client.GetJsonAsync<List<MonAn>>(apiUrl + "monan");
        }
        private void AddCart(int id)
        {
            var cart = sessionStorage.GetItem<string>("Cart");//get key cart
            if (cart == null)
            {

                var monAn = monans.Where(u => u.MonAnID == id).FirstOrDefault();
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
                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            else
            {
                var monAn = monans.Where(u => u.MonAnID == id).FirstOrDefault();

                ASM.Share.Models.Cart giohang = JsonConvert.DeserializeObject<ASM.Share.Models.Cart>(cart);
                //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                bool check = true;
                for (int i = 0; i < giohang.ListViewCart.Count; i++)
                {
                    if (giohang.ListViewCart[i].MonAn.MonAnID == id)
                    {
                        giohang.ListViewCart[i].Quantity++;
                        giohang.ListViewCart[i].Sotien = monAn.Gia * giohang.ListViewCart[i].Quantity;
                        check = false;
                    }
                }

                if (check)
                {
                    //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                    giohang.ListViewCart.Add(new CartItem
                    {
                        MonAn = monAn,
                        Quantity = 1,
                        Sotien = monAn.Gia * 1
                    });
                }
                giohang.Tongtien = Tinhtien(giohang.ListViewCart);
                sessionStorage.SetItem("Cart", JsonConvert.SerializeObject(giohang));

                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
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
    }
}