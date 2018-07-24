using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public partial class HistoricalOhlcv
    {
        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Type")]
        public long Type { get; set; }

        [JsonProperty("Aggregated")]
        public bool Aggregated { get; set; }

        [JsonProperty("Data")]
        public HistoricalOhlcvData[] Data { get; set; }

        [JsonProperty("TimeTo")]
        public long TimeTo { get; set; }

        [JsonProperty("TimeFrom")]
        public long TimeFrom { get; set; }

        [JsonProperty("FirstValueInArray")]
        public bool FirstValueInArray { get; set; }

        [JsonProperty("ConversionType")]
        public ConversionType ConversionType { get; set; }
    }
}