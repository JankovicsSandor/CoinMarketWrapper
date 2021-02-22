using CoinMarketWrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoinMarketWrapper.NetworkClient
{
    public class CoinMarketHttpClient : ICoinMarketHttpClient
    {
        private HttpClient _client;

        public CoinMarketHttpClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/v1/");
            _client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", Environment.GetEnvironmentVariable("API_KEY"));
        }

        public async Task<CoinMarketAPIResponse> GetCoinList()
        {
            HttpResponseMessage listingRequest = await _client.GetAsync("cryptocurrency/listings/latest");
            string content = await listingRequest.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<CoinMarketAPIResponse>(content);
        }
    }
}
