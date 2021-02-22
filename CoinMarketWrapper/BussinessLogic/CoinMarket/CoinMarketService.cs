using CoinMarketWrapper.Model;
using CoinMarketWrapper.NetworkClient;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.BussinessLogic.CoinMarket
{
    public class CoinMarketService : ICoinMarketService
    {
        private IMemoryCache _memoryCache;
        private ICoinMarketHttpClient _apiRequester;

        public CoinMarketService(IMemoryCache memoryCache, ICoinMarketHttpClient apiRequester)
        {
            _memoryCache = memoryCache;
            _apiRequester = apiRequester;
        }

        public async Task<CoinMarketAPIResponse> GetCoinInfoList()
        {
            CoinMarketAPIResponse cacheEntry;
            if (!_memoryCache.TryGetValue("prices", out cacheEntry))
            {
                // Key not in cache, so get data.
                cacheEntry = await _apiRequester.GetCoinList();

                // Set cache options.
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromMinutes(3));

                // Save data in cache.
                _memoryCache.Set("prices", cacheEntry, cacheEntryOptions);
            }

            return cacheEntry;
        }
    }
}
