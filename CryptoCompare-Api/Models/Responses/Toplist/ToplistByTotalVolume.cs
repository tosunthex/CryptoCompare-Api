using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class ToplistByTotalVolume
    {
        [JsonProperty("Message")] public string Message { get; set; }

        [JsonProperty("Type")] public long Type { get; set; }

        [JsonProperty("SponsoredData")] public object[] SponsoredData { get; set; }

        [JsonProperty("Data")] public ToplistByTotalVolumeData[] Data { get; set; }
    }
}