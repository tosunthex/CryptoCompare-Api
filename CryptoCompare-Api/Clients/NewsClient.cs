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

        public async Task<News> GetNews()
        {
            return await GetAsync<News>(NewsApiUrls.News(null, null, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<News> GetNews(string[] feeds, string[] categories,string[] excludeCategories, long? its,
            string lang, string sort)
        {
            return await GetAsync<News>(NewsApiUrls.News(feeds, categories, excludeCategories, its, lang, sort))
                .ConfigureAwait(false);
        }
    }
}