using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class MultipleSymbolFullData
    {
        [JsonProperty("RAW")]
        public MultipleSymbolFullDataRaw Raw { get; set; }
        [JsonProperty("DISPLAY")]
        public MultipleSymbolFullDataDisplay Display { get; set; }
    }
}