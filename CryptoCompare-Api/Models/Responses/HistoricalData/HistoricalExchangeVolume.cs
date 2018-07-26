using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class HistoricalExchangeVolume
    {
        [JsonProperty("Type")] public int Type { get; set; }

        [JsonProperty("Message")] public string Message { get; set; }

        [JsonProperty("Data")] public HistoricalExchangeVolumeData[] Data { get; set; }

        [JsonProperty("TimeFrom")] public string TimeFrom { get; set; }

        [JsonProperty("TimeTo")] public string TimeTo { get; set; }

        [JsonProperty("FirstValueInArray")] public bool FirstValueInArray { get; set; }

        [JsonProperty("ConversionType")] public string ConversionType { get; set; }
    }
}