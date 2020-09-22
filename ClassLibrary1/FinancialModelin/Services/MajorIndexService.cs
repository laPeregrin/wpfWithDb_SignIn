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
        FinancialModelingPrepHttpClientFactory _client;

        public MajorIndexService(FinancialModelingPrepHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            using (FinancialModelingPreHttpClient client =_client.CreateHttpClient())
            {
                string uri = "major-indexes/" + GetUriSuffix(indexType);
                MajorIndex majorIndex = await client.GetAsync<MajorIndex>(uri);
                majorIndex.Type = indexType;
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
                 throw new Exception("Major index type does not have a suffix defiend");
            }
        }
    }
}
