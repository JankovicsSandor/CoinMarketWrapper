using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoinMarketWrapper.Model
{
    public class TransferHistoryItem
    {
        public int AssetId { get; set; }
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public double FiatAmount { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
