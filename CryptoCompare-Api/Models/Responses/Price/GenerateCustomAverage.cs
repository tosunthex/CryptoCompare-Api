using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class GenerateCustomAverage
    {
        [JsonProperty("RAW")]
        public RawCryptoData Raw { get; set; }
        [JsonProperty("Display")]
        public DisplayCryptoData Display { get; set; }
    }
}