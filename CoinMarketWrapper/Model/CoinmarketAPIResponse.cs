using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinMarketWrapper.Model
{

    public class CoinMarketAPIResponse
    {
        public Status status { get; set; }
        public Datum[] data { get; set; }
    }

    public class Status
    {
        public DateTime timestamp { get; set; }
        public int error_code { get; set; }
        public object error_message { get; set; }
        public int elapsed { get; set; }
        public int credit_count { get; set; }
        public object notice { get; set; }
        public int total_count { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public int num_market_pairs { get; set; }
        public DateTime date_added { get; set; }
        public long? max_supply { get; set; }
        public float circulating_supply { get; set; }
        public float total_supply { get; set; }
        public int cmc_rank { get; set; }
        public DateTime last_updated { get; set; }
        public Quote quote { get; set; }
    }

    public class Quote
    {
        public USD USD { get; set; }
    }

    public class USD
    {
        public float price { get; set; }
        public float volume_24h { get; set; }
        public float percent_change_1h { get; set; }
        public float percent_change_24h { get; set; }
        public float percent_change_7d { get; set; }
        public float percent_change_30d { get; set; }
        public float market_cap { get; set; }
        public DateTime last_updated { get; set; }
    }

}
