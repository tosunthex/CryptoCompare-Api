using CryptoCompare_Api.Models.Responses.Streaming;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class TopExchangesFullDataByPairData
    {
        [JsonProperty("CoinInfo")] public CoinInfo CoinInfo { get; set; }

        [JsonProperty("AggregatedData")] public AggregatedData AggregatedData { get; set; }

        [JsonProperty("Exchanges")] public AggregatedData[] Exchanges { get; set; }
    }
}