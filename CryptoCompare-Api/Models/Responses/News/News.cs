using System.Collections.Generic;

namespace CryptoCompare_Api.Models.Responses.News
{
    public class News
    {
        public int Type { get; set; }
        public string Message { get; set; }
        public IEnumerable<NewsPromoted> Promoted { get; set; }
        public IEnumerable<NewsData> Data { get; set; }
    }
}