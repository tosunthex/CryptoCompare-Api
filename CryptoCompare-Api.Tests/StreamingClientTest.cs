﻿using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using Xunit;

namespace CryptoCompare.Tests
{
    public class StreamingClientTest
    {
        public StreamingClientTest()
        {
            _cryproCompareClient = new CryptoCompareClient();
        }

        private readonly CryptoCompareClient _cryproCompareClient;

        [Fact]
        public async Task Coins_General_Info_BTC_MLN_DASH_TO_USD()
        {
            var fsyms = new[]
            {
                "BTC", "MLN", "DASH"
            };
            var generelInfo = await _cryproCompareClient.StreamingClient.GetCoinGeneralInfo(fsyms, "USD");
            Assert.Equal(3, generelInfo.Data.Length);
            Assert.Equal("BTC", generelInfo.Data.First().CoinInfo.Name);
        }

        [Fact]
        public async Task Sub_Watchlist_BTC_MLN_DASH_TO_USD()
        {
            var fsyms = new[]
            {
                "BTC", "MLN", "DASH"
            };
            var streaming = await _cryproCompareClient.StreamingClient.GetSubsWatchList(fsyms, "USD");
            Assert.Equal(3, streaming.Count);
            Assert.Equal("BTC", streaming.Values.First().CurrencyFrom);
            Assert.Equal("USD", streaming.Values.First().CurrencyTo);
        }

        [Fact]
        public async Task Sub_Watchlist_Required_Parameter_Error()
        {
            var hrEx = await Assert.ThrowsAsync<HttpRequestException>(async () =>
                await _cryproCompareClient.StreamingClient.GetSubsWatchList(new[] {""}, ""));
        }

        [Fact]
        public async Task Subs_By_Pair_BTC_To_USD()
        {
            var SubsByPair = await _cryproCompareClient.StreamingClient.GetSubsByPair("BTC", new[] {"USD"});
            Assert.Equal("5~CCCAGG~BTC~USD", SubsByPair.Values.First().Currentagg);
        }
    }
}