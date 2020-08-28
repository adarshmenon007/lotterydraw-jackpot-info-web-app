using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LotteryDrawJackpotInfo.ApiServices;
using LotteryDrawJackpotInfo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace LotteryDrawJackpotInfo.Tests
{
    [TestClass]
    public class LotteryDrawJackpotInfoTests
    {
        /// <summary>
        /// This test methods hits the API and should return a valid response if the request to PostAsync has the correct BaseAddress and JSON string
        /// </summary>
        /// <returns>
        /// HttpResponseMessage
        /// </returns>
        [TestMethod]
        public async Task GetOpenDrawsInformationMethodShouldReturnValidResponseForValidRequest()
        {
            ApiHelper.InitializeClient();

            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.Tattersalls;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString()};

            var jsonString = JsonConvert.SerializeObject(requestContent);
            StringContent queryString = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(ApiHelper.ApiClient.BaseAddress, queryString);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(jsonString));
            Assert.IsNotNull(ApiHelper.ApiClient.BaseAddress);
            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.IsTrue(response.StatusCode.Equals(System.Net.HttpStatusCode.OK));
        }

        /// <summary>
        /// This test methods hits the API and should return a valid response for a valid request
        /// </summary>
        /// <returns>
        /// DrawsResponse
        /// </returns>
        [TestMethod]
        public async Task GetOpenDrawsInformationMethodShouldReturnDeserializeObjectForValidRequest()
        {
            ApiHelper.InitializeClient();

            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.Tattersalls;
            requestContent.MaxDrawCount = 5;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString() };

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            Assert.IsNotNull(drawResults);
            Assert.IsNull(drawResults.ErrorInfo);
            Assert.IsTrue(drawResults.Success);
            Assert.AreEqual(drawResults.Draws.Count, 5);
            Assert.AreEqual(drawResults.Draws[0].ProductId, Common.LotteriesProduct.TattsLotto);
        }
    }
}
