using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.News;

namespace CryptoCompare_Api.Clients
{
    public interface INewsClient
    {
        /// <summary>
        /// Returns all the news feeds (providers) that CryptoCompare has integrated with.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NewsFeed>> GetNewsFeeds();
        /// <summary>
        /// Returns news articles categories, you can use them to filter news.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NewsCategory>> GetNewsCategories();
        /// <summary>
        /// Returns all the news feeds (providers) that CryptoCompare has integrated with and the full list of categories.
        /// </summary>
        /// <returns></returns>
        Task<FeedAndCategory> GetFeedsAndCategories();
        /// <summary>
        /// Returns news articles from the providers that CryptoCompare has integrated with.
        /// </summary>
        /// <param name="feeds">Specific news feeds to retrieve news from [Max character length: 400]</param>
        /// <param name="categories">Category of news articles to return [Max character length: 400]</param>
        /// <param name="excludeCategories">News article categories to exclude from results [Max character length: 400]</param>
        /// <param name="its">Returns news before that timestamp</param>
        /// <param name="lang">Preferred language - English (EN) or Portuguese (PT) [Max character length: 4]</param>
        /// <param name="sort">The order to return news articles - latest or popular [Max character length: 8]</param>
        /// <returns></returns>
        Task<News> GetNews(string[] feeds=null,string[] categories=null,string[] excludeCategories=null, long? its = null, string lang = null,string sort = null);
    }
}
