using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Streaming
{
    public class SubsByPairData
    {
        [JsonProperty("TRADES")]
        public string[] Trades { get; set; }

        [JsonProperty("CURRENT")]
        public string[] Current { get; set; }

        [JsonProperty("CURRENTAGG")]
        public string Currentagg { get; set; }
    }
}