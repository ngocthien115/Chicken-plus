using ASM.Share.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ASM.Client.Pages
{
    public partial class History
    {
        [Parameter]
        public string id { get; set; }
        public List<Donhang> donhangs = new List<Donhang>();
        protected override async Task OnInitializedAsync()
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var strJson = await client.GetStringAsync(apiUrl + "donhang/" + id);
                donhangs = JsonConvert.DeserializeObject<List<Donhang>>(strJson).ToList();
                
            }
        }
    }
}
