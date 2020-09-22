using FinancialModelin.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialModelin
{
    public class FinancialModelingPrepHttpClientFactory
    {
        private readonly string _apiKey;

        public FinancialModelingPrepHttpClientFactory(string apiKey= "1895ae0577427f4130678a03b37295bd")
        {
            _apiKey = apiKey;
        }

        public FinancialModelingPreHttpClient CreateHttpClient()
        {
            return new FinancialModelingPreHttpClient(_apiKey);
        }
    }
}
