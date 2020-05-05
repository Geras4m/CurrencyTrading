using OXR.Trading.ApiFramework.Models;
using OXR.Trading.Common.Helpers;
using RestSharp;
using System.Collections.Generic;

namespace OXR.Trading.ApiFramework
{
    internal class OXRatesClient : IOXRatesClient
    {
        private readonly RestClient _client;
        public OXRatesClient()
            => _client = new RestClient(ConstantStrings.OXRatesClientUrl);


        public IOXRatesResponse<LatestRates> GetLatestRates()
            => OnGet<LatestRates>("latest.json");


        private IOXRatesResponse<TModel> OnGet<TModel>(string method)
            where TModel : new()
        {
            var appId = "?app_id=cafa450005484b9c865dd93177f57af8";
            var request = new RestRequest(method + appId, Method.GET);
            var response = _client.Execute<TModel>(request);

            return new OXRatesResponse<TModel>
            {
                StatusCode = response.StatusCode,
                Data = response.Data
            };
        }
    }
}
