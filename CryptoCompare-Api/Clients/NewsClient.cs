using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.News;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class NewsClient:BaseApiClient,INewsClient
    {
        public async Task<IEnumerable<NewsFeed>> GetNewsFeeds()
        {
            return await GetAsync<IEnumerable<NewsFeed>>(ApiUrls.NewsFeeds()).ConfigureAwait(false);
        }

        public async Task<IEnumerable<NewsCategory>> GetNewsCategories()
        {
            return await GetAsync<IEnumerable<NewsCategory>>(ApiUrls.NewsCategories()).ConfigureAwait(false);
        }

        public async Task<FeedAndCategory> GetFeedsAndCategories()
        {
            return await GetAsync<FeedAndCategory>(ApiUrls.FeedsAndCategories()).ConfigureAwait(false);
        }

        public async Task<News> GetNews(string[] feeds = null, string[] categories = null, string[] excludeCategories = null, long? its = null,
            string lang = null, string sort = null)
        {
            return await GetAsync<News>(ApiUrls.News(feeds,categories,excludeCategories,its,lang,sort)).ConfigureAwait(false);
        }

        public NewsClient(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}