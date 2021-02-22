using CoinMarketWrapper.BussinessLogic.CoinMarket;
using CoinMarketWrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.BussinessLogic.Asset
{
    public class AssetService : IAssetService
    {
        private ICoinMarketService _coinService;

        public AssetService(ICoinMarketService coinService)
        {
            _coinService = coinService;
        }

        public async Task<Datum> GetAssetById(int id)
        {
            CoinMarketAPIResponse allCoin = await _coinService.GetCoinInfoList();

            return allCoin.data.FirstOrDefault(e => e.id == id);
        }
    }
}
