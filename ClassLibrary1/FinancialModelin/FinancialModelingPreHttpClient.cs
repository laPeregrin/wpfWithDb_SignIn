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
        public FinancialModelingPreHttpClient()
        {
            this.BaseAddress = new Uri("https://financialmodelingprep.com/api/v3/");
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage responce = await GetAsync($"{uri}?apikey=1895ae0577427f4130678a03b37295bd");
            string jsonResponce = await responce.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonResponce);
        }
    }
}