using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public partial class ToplistofTradingPair
    {
        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Data")]
        public ToplistofTradingPairData[] Data { get; set; }
    }
}