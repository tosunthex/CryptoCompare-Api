﻿using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Clients;
using Xunit;

namespace CryptoCompare.Tests
{
    public class HistoricaldataTests
    {
        public HistoricaldataTests()
        {
            _cryptoCompareClient = new CryptoCompareClient(new HttpClientHandler(), "ab56a1fcd21d7faaefdb8a01e5efb0b14242f3af589f32cfcf942b0aec5a7731");
        }

        private readonly CryptoCompareClient _cryptoCompareClient;

        [Fact]
        public async Task Historical_Daily_OHLCV()
        {
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalDailyOhlcv("BTC", "USD", "CCCAGG", 3,5,null);
            Assert.Equal("Success", response.Response);
        }

        [Fact]
        public async Task Historical_Day_Average_Price()
        {
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalDayAveragePrice("BTC", "USD", null, null,
                    null, "1487116600");
            Assert.Equal("USD", response.Keys.First());
            Assert.Equal(1003.81, response["USD"]);
        }

        [Fact]
        public async Task Historical_Day_Exchange_Volume()
        {
            var limit = 10;
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalDailyExchangeVolume("USD", null, null,
                    limit,null);
            Assert.Equal("Got the data", response.Message);
            Assert.Equal(limit+1, response.Data.Length);
        }

        [Fact]
        public async Task Historical_Day_OHLCV_for_a_TS()
        {
            var tsyms = new[] {"USD", "EUR"};
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalDayOhlcvForaTs("BTC", tsyms, "1452680400",null,null);
            Assert.Equal("BTC", response.Keys.First());
            Assert.Equal("USD", response.Values.First().Keys.First());
        }

        [Fact]
        public async Task Historical_Hourly_Exchange_Volume()
        {
            var limit = 10;
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalHourlyExchangeVolume("USD", null, null,
                    limit,null);
            Assert.Equal("Got the data", response.Message);
            Assert.Equal(limit+1, response.Data.Length);
        }

        [Fact]
        public async Task Historical_Hourly_OHLCV()
        {
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalHourlyOhlcv("BTC", "USD", "CCCAGG", 3, 5,null);
            Assert.Equal("Success", response.Response);
        }

        [Fact]
        public async Task Historical_Minute_OHLCV()
        {
            var response =
                await _cryptoCompareClient.HistoricalDataClient.GetHistoricalMinuteOhlcv("BTC", "USD", "CCCAGG", 3, 5,null);
            Assert.Equal("Success", response.Response);
        }
    }
}