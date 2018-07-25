using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class HistoricalExchangeVolumeData
    {
        [JsonProperty("time")] public long Time { get; set; }

        [JsonProperty("volume")] public double Volume { get; set; }
    }
}