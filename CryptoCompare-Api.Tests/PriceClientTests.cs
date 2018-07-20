using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using Xunit;

namespace CryptoCompare.Tests
{
    public class PriceClientTests
    {
        private readonly CryptoCompareClient _cryptoCompareClient;
        public PriceClientTests()
        {
            _cryptoCompareClient = new CryptoCompareClient();
        }

        [Fact]
        public async Task Multiple_Symbol_Fulldata_BTC_ETH_To_USD_EUR()
        {
            var priceMultipleFulldata = await _cryptoCompareClient.PriceClient.GetMultipleSymbolFullData(new string[] {"BTC,ETH"}, new string[] {"USD,EUR"});
            Assert.Equal("BTC",priceMultipleFulldata.Raw.Values.First().Values.First().Fromsymbol);
            Assert.Equal("USD",priceMultipleFulldata.Raw.Values.First().Values.First().Tosymbol);
            Assert.Equal("CryptoCompare Index",priceMultipleFulldata.Display.Values.First().Values.First().Market);
        }

        [Fact]
        public async Task Multiple_Symbol_Price_BTC_ETH_To_USD_EUR()
        {
            var priceMultiple =
                await _cryptoCompareClient.PriceClient.GetMultipleSymbolPrice(new string[] {"BTC,ETH"},
                    new string[] {"USD,EUR"});
            Assert.Equal("BTC",priceMultiple.Keys.First());
            Assert.Equal("ETH",priceMultiple.Keys.Last());
            Assert.Equal("USD",priceMultiple.Values.First().Keys.First());
            Assert.Equal("EUR",priceMultiple.Values.First().Keys.Last());
        }

        [Fact]
        public async Task Single_Symbol_Price_BTC()
        {
            var singleSymbol =await _cryptoCompareClient.PriceClient.GetSingleSymbolPrice("BTC",new string[]{"USD,EUR"});
            Assert.Equal("USD",singleSymbol.Keys.First());
            Assert.Equal("EUR",singleSymbol.Keys.Last());
        }

        [Fact]
        public async Task Generate_Custom_Average_BTC_USD_Kraken()
        {
            var generateCustom =
                await _cryptoCompareClient.PriceClient.GetGenerateCustomAverage("BTC", new string[] {"USD"},
                    new string[] {"Kraken"});
            Assert.Equal("BTC",generateCustom.Raw.Fromsymbol);
            Assert.Equal("USD",generateCustom.Raw.Tosymbol);
            Assert.Equal("Kraken",generateCustom.Raw.Lastmarket);
        }

        [Fact]
        public async Task Unlisted_Crypto_Generate_Http_Request_Exception()
        {
            HttpRequestException hrEx = await Assert.ThrowsAsync<HttpRequestException>(async () => await _cryptoCompareClient.PriceClient.GetSingleSymbolPrice("XXXX", new string[] { "USD" }));
        }
    }
}