using CoinMarketWrapper.Model;
using System.Threading.Tasks;

namespace CoinMarketWrapper.BussinessLogic.CoinMarket
{
    public interface ICoinMarketService
    {
        Task<CoinMarketAPIResponse> GetCoinInfoList();
    }
}