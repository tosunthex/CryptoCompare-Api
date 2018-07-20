using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public partial class TopExchangesFullDataByPair
    {
        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Data")]
        public TopExchangesFullDataByPairData Data { get; set; }
    }
}