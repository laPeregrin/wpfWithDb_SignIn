using FinancialModelin.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialModelin.Services
{
    public class FinancialModelingPreHttpClient : HttpClient
    {
        private readonly string _apiKey;
        public FinancialModelingPreHttpClient(string apiKey)
        {
            this.BaseAddress = new Uri("https://financialmodelingprep.com/api/v3/");
            _apiKey = apiKey;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage responce = await GetAsync($"{uri}?apikey={_apiKey}");
            string jsonResponce = await responce.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonResponce);
        }
    }
}