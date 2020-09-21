using Domain.Exceptions;
using Domain.Services;
using FinancialModelin.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModelin.Services
{
    public class  StockPriceService : IStockPriceService
    {
        public async Task<double> GetPrice(string symbol)
        {
            using (FinancialModelingPreGttpClient client = new FinancialModelingPreGttpClient())
            {
                string uri = "stock/real=time-price/" + symbol;

                StockPriceResult stockPriceResult = await client.GetAsync<StockPriceResult>(uri);
               if(stockPriceResult.Price == 0)
                {
                   throw new InvalidSymbolException(symbol);
                }
                return stockPriceResult.Price;
            }
        }
    }
}
