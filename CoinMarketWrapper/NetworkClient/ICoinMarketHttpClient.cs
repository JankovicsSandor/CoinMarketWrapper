using CoinMarketWrapper.Model;
using System.Threading.Tasks;

namespace CoinMarketWrapper.NetworkClient
{
    public interface ICoinMarketHttpClient
    {
        Task<CoinMarketAPIResponse> GetCoinList();
    }
}