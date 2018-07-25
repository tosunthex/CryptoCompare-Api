using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class ToplistByPairVolume
    {
        [JsonProperty("Data")] public ToplistByPairVolumeData[] Data { get; set; }

        [JsonProperty("Type")] public long Type { get; set; }

        [JsonProperty("Response")] public string Response { get; set; }

        [JsonProperty("VolSymbol")] public string VolSymbol { get; set; }

        [JsonProperty("Message")] public string Message { get; set; }
    }
}