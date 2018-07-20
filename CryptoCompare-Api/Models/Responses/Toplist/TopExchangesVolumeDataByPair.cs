using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class TopExchangesVolumeDataByPair
    {
        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Data")]
        public TopExchangesVolumeDataByPairData[] Data { get; set; }
    }
}