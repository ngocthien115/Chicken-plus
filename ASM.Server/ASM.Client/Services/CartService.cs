using ASM.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using Newtonsoft.Json;

namespace ASM.Client.Services
{
	public class CartService : ICartService
	{
		private readonly ISessionStorageService _sessionStorage;
		public event Action OnChange;

		public CartService(ISessionStorageService sessionStorage)
		{
			_sessionStorage = sessionStorage;
		}

		public async Task AddToCart(List<MonAn> monans, int id)
		{
            Cart cart = await _sessionStorage.GetItemAsync<Cart>("Cart");//get key cart
            if (cart == null)
            {
                var monan = monans.Where(f => f.MonAnID == id).Single();
                List<CartItem> ListCart = new List<CartItem>()
                {
                    new CartItem{
                        MonAn = monan,
                        Quantity = 1,
                        Sotien= monan.Gia
                        }
                };

                ASM.Share.Models.Cart giohang = new ASM.Share.Models.Cart()
                {
                    ListViewCart = cart,
                    Tongtien = Tinhtien(cart)
                };
                await _sessionStorage.SetItemAsync("Cart", JsonConvert.SerializeObject(giohang));
            }
            else
            {
                var monAn = monans.Where(u => u.MonAnID == id).FirstOrDefault();
                Cart giohang = cart;
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
                    giohang.ListViewCart.Add(new CartItem
                    {
                        MonAn = monAn,
                        Quantity = 1,
                        Sotien = monAn.Gia * 1
                    });
                }
                giohang.Tongtien = Tinhtien(giohang.ListViewCart);
                await _sessionStorage.SetItemAsync("Cart", JsonConvert.SerializeObject(giohang));
            }
            OnChange.Invoke();
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
