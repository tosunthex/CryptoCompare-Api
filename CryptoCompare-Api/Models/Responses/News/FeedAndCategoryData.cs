using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class FeedAndCategoryData
    {
        [JsonProperty("Feeds")] public List<NewsFeed> NewsFeeds { get; set; }

        [JsonProperty("Categories")] public List<NewsCategory> NewsCategories { get; set; }
    }
}