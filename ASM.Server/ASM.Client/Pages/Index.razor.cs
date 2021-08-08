using ASM.Share.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace ASM.Client.Pages
{
    public partial class Index
    {
        protected string imgUrl = "";
        protected string temp = "";
        public List<MonAn> monans;

        private int totalPageQuantity;
        private int currentPage = 1;

        private async Task SelectedPage(int page)
        {
            currentPage = page;
            await LoadData(page);
        }

        protected async Task LoadData(int page = 1, int quantityPerPage = 10)
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();
            HttpResponseMessage httpResponse = await client.GetAsync(apiUrl + $"monan?page={page}&quantityPerPage={quantityPerPage}");
            if (httpResponse.IsSuccessStatusCode)
            {
                var re = httpResponse;
                var headers = re.Headers;

                if (headers.Contains("soluongtrang"))
                {
                    string soluongtrang = headers.GetValues("soluongtrang").First();
                    Console.WriteLine("da tim thay");
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }

                //totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("soluongtrang").FirstOrDefault());
                var responseString = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                monans = System.Text.Json.JsonSerializer.Deserialize<List<MonAn>>(responseString,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            else
            {
                //handle error
            }
        }
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }
        

        private void AddCart(int id)
        {
            CartService.AddToCart(monans, id);
        }
    }
}