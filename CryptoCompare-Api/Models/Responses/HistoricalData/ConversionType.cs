using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class ConversionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("conversionSymbol")]
        public string ConversionSymbol { get; set; }
    }
}