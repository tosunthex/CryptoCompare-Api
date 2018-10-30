using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
    public class RateLimitStats
    {
        [JsonProperty("CallsMade")]
        public Calls CallsMade { get; set; }

        [JsonProperty("CallsLeft")]
        public Calls CallsLeft { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }
    public class Calls
    {
        [JsonProperty("Histo")]
        public long Histo { get; set; }

        [JsonProperty("Price")]
        public long Price { get; set; }

        [JsonProperty("News")]
        public long News { get; set; }

        [JsonProperty("Strict")]
        public long Strict { get; set; }
    }
}