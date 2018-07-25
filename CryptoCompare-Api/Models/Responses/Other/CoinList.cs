using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
public class Coinlist
    {
        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Data")]
        public Dictionary<string, CoinlistData> Data { get; set; }

        [JsonProperty("BaseImageUrl")]
        public string BaseImageUrl { get; set; }

        [JsonProperty("BaseLinkUrl")]
        public string BaseLinkUrl { get; set; }
    }
}