using System;
using System.Linq;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using Xunit;

namespace CryptoCompare.Tests
{
    public class NewsClientTests
    {
        public NewsClientTests()
        {
            _cryptoCompareClient = CryptoCompareClient.Instance;
        }

        private readonly CryptoCompareClient _cryptoCompareClient;

        [Fact]
        public async Task Check_Multiple_Feeds()
        {
            var feeds = new[] {"coindesk", "cryptocompare"};
            var categories = new[] {"ICO"};
            var excludeCategories = new[] {"Exchange", "BTC"};
            var news = await _cryptoCompareClient.NewsClient.GetNews(feeds, categories, excludeCategories,null,null,null);
            Assert.Equal("News list successfully returned", news.Message);
        }

        [Fact]
        public async Task Check_News_Client_Success()
        {
            var news = await _cryptoCompareClient.NewsClient.GetNews();
            Assert.Equal("News list successfully returned", news.Message);
        }

        [Fact]
        public async Task Feeds_And_Categories()
        {
            var newsAndCategories = await _cryptoCompareClient.NewsClient.GetFeedsAndCategories();
            Console.WriteLine(newsAndCategories.Data.NewsCategories.First().CategoryName);
            Assert.Equal("BTC", newsAndCategories.Data.NewsCategories.First().CategoryName);
            Assert.Equal("cryptocompare", newsAndCategories.Data.NewsFeeds.First().Key);
        }

        [Fact]
        public async Task First_Provider_Must_Be_CryptoCompare()
        {
            var newsFeeds = await _cryptoCompareClient.NewsClient.GetNewsFeeds();
            Assert.Equal("cryptocompare", newsFeeds.First().Key);
        }

        [Fact]
        public async Task News_Category()
        {
            var newsCategory = await _cryptoCompareClient.NewsClient.GetNewsCategories();
            Assert.Equal("BTC", newsCategory.First().CategoryName);
        }
    }
}