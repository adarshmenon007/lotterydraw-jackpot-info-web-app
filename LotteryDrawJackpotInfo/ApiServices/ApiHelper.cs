using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LotteryDrawJackpotInfo.ApiServices
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://data.api.thelott.com/sales/vmax/web/data/lotto/opendraws/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}