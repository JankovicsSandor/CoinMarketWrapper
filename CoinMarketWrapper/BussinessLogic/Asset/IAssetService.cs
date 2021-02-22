using CoinMarketWrapper.Model;
using System.Threading.Tasks;

namespace CoinMarketWrapper.BussinessLogic.Asset
{
    public interface IAssetService
    {
        Task<Datum> GetAssetById(int id);
    }
}