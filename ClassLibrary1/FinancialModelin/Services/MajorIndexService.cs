using Domain.Models;
using Domain.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModelin.Services
{
    public class MajorIndexService : IMajorIndexService
    {
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://financialmodelingprep.com//api/v3/major-indexes/" + GetUriSuffix(indexType);
                HttpResponseMessage responce = await client.GetAsync(
                    "/symbol");
                string jsonResponce = await responce.Content.ReadAsStringAsync();
                MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponce);
                return majorIndex;
            }
        }
        private string GetUriSuffix(MajorIndexType indexType)
        {
            switch (indexType)
            {
                case MajorIndexType.DownJones:
                    return " .DJI";
                case MajorIndexType.Nasdaq:
                    return ".INIC";
                case MajorIndexType.SP500:
                    return ".INX";
                default:
                    return ".DJI";
            }
        }
    }
}
