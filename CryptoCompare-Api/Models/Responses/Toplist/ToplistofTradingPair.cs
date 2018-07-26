using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class ToplistofTradingPair
    {
        [JsonProperty("Response")] public string Response { get; set; }

        [JsonProperty("Data")] public ToplistData[] Data { get; set; }
    }
}