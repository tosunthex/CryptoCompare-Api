using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class NewsData:NewsPromoted
    {
        [JsonProperty("upvotes")] public string Upvotes { get; set; }

        [JsonProperty("downvotes")] public string Downvotes { get; set; }
    }
}