using CoinMarketWrapper.Model;
using System.Collections.Generic;

namespace CoinMarketWrapper.BussinessLogic.History
{
    public interface ITransactionHistoryService
    {
        IEnumerable<TransferHistoryItem> GetTransactionHistory(string userId);
    }
}