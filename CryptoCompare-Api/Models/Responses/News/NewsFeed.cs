using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class NewsFeed
    {
        [JsonProperty("key")] public string Key { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("lang")] public string Lang { get; set; }

        [JsonProperty("img")] public string Img { get; set; }
    }
}