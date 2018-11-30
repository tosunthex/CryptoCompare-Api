using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using CryptoCompare_Api.Parameters;
using Xunit;

namespace CryptoCompare.Tests
{
    public class OtherClientTest
    {
        public OtherClientTest()
        {
            _cryptoCompareClient = new CryptoCompareClient(new HttpClientHandler(), "API_Key");
        }

        private readonly CryptoCompareClient _cryptoCompareClient;

        [Fact]
        public async Task BTC_Socialstat()
        {
            var btcId = 1182;
            var response = await _cryptoCompareClient.OtherClient.GetSocialStat(btcId);
            Assert.Equal("Social data successfully returned", response.Message);
            Assert.Equal("Success", response.Response);
        }

        [Fact]
        public async Task Coinlist()
        {
            var response = await _cryptoCompareClient.OtherClient.GetCoinList();
            Assert.Equal("Coin list succesfully returned!", response.Message);
            Assert.Equal("Success", response.Response);
        }

        [Fact]
        public async Task Mining_Equipment()
        {
            var response = await _cryptoCompareClient.OtherClient.GetMiningEquipment();
            Assert.Equal("Mining contracts data successfully returned", response.Message);
            Assert.Equal("Success", response.Response);
        }

        [Fact]
        public async Task All_Exchages()
        {
            var response = await _cryptoCompareClient.OtherClient.GetAllExchanges();
            Assert.Equal("Cryptsy",response.First().Key);
            Assert.NotEqual(0,response["Bitfinex"].Count);
        }
        [Fact]
        public async Task Cccagg_Exchages()
        {
            var response = await _cryptoCompareClient.OtherClient.GetCccaggExchanges();
            Assert.Equal("Cryptsy", response.First().Key);
            Assert.True(response["Coinbase"].IsActive);
        }
    }
}