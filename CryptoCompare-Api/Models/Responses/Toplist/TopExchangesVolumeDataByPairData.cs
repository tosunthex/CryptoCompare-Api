using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class TopExchangesVolumeDataByPairData
    {
        [JsonProperty("exchange")] public string Exchange { get; set; }

        [JsonProperty("fromSymbol")] public string FromSymbol { get; set; }

        [JsonProperty("toSymbol")] public string ToSymbol { get; set; }

        [JsonProperty("volume24h")] public double Volume24H { get; set; }

        [JsonProperty("volume24hTo")] public double Volume24HTo { get; set; }
    }
}