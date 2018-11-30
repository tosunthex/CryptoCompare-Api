using System.Linq;
using System.Net.Http;
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
            _cryptoCompareClient = new CryptoCompareClient(new HttpClientHandler(), "ab56a1fcd21d7faaefdb8a01e5efb0b14242f3af589f32cfcf942b0aec5a7731");
        }

        

        [Fact]
        public async Task TopExchanges_Full_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetTopExchangesFullDataByPair("BTC", "USD");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.Data.CoinInfo.Name);
        }

        [Fact]
        public async Task TopExchangesVolume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetTopExchangesVolumeDataByPair("BTC", "USD");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.Data.First().FromSymbol);
        }

        [Fact]
        public async Task Toplist_by_Pair_Volume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistByPairVolume("BTC");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.VolSymbol);
        }

        [Fact]
        public async Task Toplist_by_Total_Volume_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistByTotalVolume("BTC");
            Assert.Equal("Success", ex.Message);
            Assert.Equal("BTC", ex.Data.First().CoinInfo.Name);
        }

        [Fact]
        public async Task Toplist_of_Trading_Pair_Response_Success_BTC_TO_USD()
        {
            var ex = await _cryptoCompareClient.ToplistClient.GetToplistOfTradingPairs("BTC");
            Assert.Equal("Success", ex.Response);
            Assert.Equal("BTC", ex.Data.First().FromSymbol);
        }
    }
}