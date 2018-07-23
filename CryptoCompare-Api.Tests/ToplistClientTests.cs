using System.Linq;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using Xunit;

namespace CryptoCompare.Tests
{
    public class ToplistClientTests
    {
        private readonly CryptoCompareClient _cryptoCompareClient;
        public ToplistClientTests()
        {
            _cryptoCompareClient = CryptoCompareClient.Instance;
        }

        [Fact]
        public async Task TopExchangesVolume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetTopExchangesVolumeDataByPair("BTC", "USD");
            Assert.Equal("Success",ex.Response);
            Assert.Equal("BTC", ex.Data.First().FromSymbol);
        }
        [Fact]
        public async Task TopExchanges_Full_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetTopExchangesFullDataByPair("BTC", "USD");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.Data.CoinInfo.Name);
        }
        [Fact]
        public async Task Toplist_by_Pair_Volume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistByPairVolume("BTC");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.VolSymbol);
        }
        [Fact]
        public async Task Toplist_of_Trading_Pair_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistOfTradingPairs("BTC");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.Data.First().FromSymbol);
        }
        [Fact]
        public async Task Toplist_by_Total_Volume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistByTotalVolume("BTC");
            Assert.Equal("Success", ex.Message);
            Assert.Equal("BTC", ex.Data.First().CoinInfo.Name);
        }
    }
}