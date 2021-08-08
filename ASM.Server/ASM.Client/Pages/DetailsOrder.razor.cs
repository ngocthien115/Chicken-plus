using ASM.Share.Models.ViewModels;
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
    public partial class DetailsOrder
    {
        [Parameter]
        public string id { get; set; }
        List<ViewDetails> details = null;
        string imgUrl = "";
        protected string temp;

        protected override async Task OnInitializedAsync()
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            imgUrl = config.GetSection("API")["ImgUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var strJson = await client.GetStringAsync(apiUrl + "donhangchitiet/" + id);
                details = JsonConvert.DeserializeObject<List<ViewDetails>>(strJson).ToList();
            }
        }
    }
}
