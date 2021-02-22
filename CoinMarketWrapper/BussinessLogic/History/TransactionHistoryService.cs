using CoinMarketWrapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.BussinessLogic.History
{
    public class TransactionHistoryService : ITransactionHistoryService
    {
        public TransactionHistoryService()
        {

        }

        public IEnumerable<TransferHistoryItem> GetTransactionHistory(string userId)
        {
            return new List<TransferHistoryItem>()
            {
                new TransferHistoryItem()
                {
                    AssetId=1,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Buy,
                    Amount=10,
                    FiatAmount=10000
                },
                new TransferHistoryItem()
                {
                    AssetId=1,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Buy,
                    Amount=10,
                    FiatAmount=10000
                },new TransferHistoryItem()
                {
                    AssetId=825,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Buy,
                    Amount=10,
                    FiatAmount=10000
                },new TransferHistoryItem()
                {
                    AssetId=1839,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Buy,
                    Amount=10,
                    FiatAmount=10000
                },new TransferHistoryItem()
                {
                    AssetId=1027,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Buy,
                    Amount=10,
                    FiatAmount=10000
                },
                 new TransferHistoryItem()
                {
                    AssetId=1,
                    Time=DateTime.Now.AddHours(-1),
                    TransactionType=TransactionType.Sell,
                    Amount=10,
                    FiatAmount=20000
                }
            };
        }
    }
}
