using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class NewsData
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("guid")] public string Guid { get; set; }

        [JsonProperty("published_on")] public int PublishedOn { get; set; }

        [JsonProperty("imageurl")] public string Imageurl { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("source")] public string Source { get; set; }

        [JsonProperty("body")] public string Body { get; set; }

        [JsonProperty("tags")] public string Tags { get; set; }

        [JsonProperty("categories")] public string Categories { get; set; }

        [JsonProperty("upvotes")] public string Upvotes { get; set; }

        [JsonProperty("downvotes")] public string Downvotes { get; set; }

        [JsonProperty("lang")] public string Lang { get; set; }

        [JsonProperty("")] public NewsSourceInfo source_info { get; set; }
    }
}