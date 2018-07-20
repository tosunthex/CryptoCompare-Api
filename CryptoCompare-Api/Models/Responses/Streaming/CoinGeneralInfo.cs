using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Streaming
{
    public partial class CoinGeneralInfo
    {
        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Type")]
        public long Type { get; set; }

        [JsonProperty("Data")]
        public CoinGeneralInfoData[] Data { get; set; }
    }
}