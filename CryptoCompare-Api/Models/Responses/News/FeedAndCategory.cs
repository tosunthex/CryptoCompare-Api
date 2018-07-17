using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class FeedAndCategory
    {
        [JsonProperty("Response")]
        public string Response { get; set; }
        [JsonProperty("Message")]
        public string Message { get; set; }
        [JsonProperty("Type")]
        public int Type { get; set; }
        [JsonProperty("Data")]
        public FeedAndCategoryData Data { get; set; }
    }
}