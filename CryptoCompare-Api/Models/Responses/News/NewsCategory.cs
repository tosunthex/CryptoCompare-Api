using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class NewsCategory
    {
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
        [JsonProperty("wordsAssociatedWithCategory")]
        public List<string> WordsAssociatedWithCategory { get; set; }
    }
}