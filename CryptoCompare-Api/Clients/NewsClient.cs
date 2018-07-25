using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.News;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class NewsClient : BaseApiClient, INewsClient
    {
        public NewsClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<IEnumerable<NewsFeed>> GetNewsFeeds()
        {
            return await GetAsync<IEnumerable<NewsFeed>>(NewsApiUrls.NewsFeeds()).ConfigureAwait(false);
        }

        public async Task<IEnumerable<NewsCategory>> GetNewsCategories()
        {
            return await GetAsync<IEnumerable<NewsCategory>>(NewsApiUrls.NewsCategories()).ConfigureAwait(false);
        }

        public async Task<FeedAndCategory> GetFeedsAndCategories()
        {
            return await GetAsync<FeedAndCategory>(NewsApiUrls.FeedsAndCategories()).ConfigureAwait(false);
        }

        public async Task<News> GetNews(string[] feeds = null, string[] categories = null,
            string[] excludeCategories = null, long? its = null,
            string lang = null, string sort = null)
        {
            return await GetAsync<News>(NewsApiUrls.News(feeds, categories, excludeCategories, its, lang, sort))
                .ConfigureAwait(false);
        }
    }
}