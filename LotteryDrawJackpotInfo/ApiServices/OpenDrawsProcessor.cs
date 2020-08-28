using LotteryDrawJackpotInfo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LotteryDrawJackpotInfo.ApiServices
{
    public class OpenDrawsProcessor
    {
        public static async Task<DrawsResponse> GetOpenDrawsInformation(DrawsRequestItem requestContent)
        {
            var jsonString = JsonConvert.SerializeObject(requestContent);

            StringContent queryString = new StringContent(jsonString, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(ApiHelper.ApiClient.BaseAddress, queryString))
            {
                if (response.IsSuccessStatusCode)
                {
                    string drawsString = await response.Content.ReadAsStringAsync();

                    DrawsResponse draws = JsonConvert.DeserializeObject<DrawsResponse>(drawsString);

                    return draws;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}