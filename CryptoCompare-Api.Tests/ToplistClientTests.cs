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
    }
}