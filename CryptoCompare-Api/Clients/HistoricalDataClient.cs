using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.HistoricalData;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class HistoricalDataClient : BaseApiClient, IHistorocalDataClient
    {
        public HistoricalDataClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<HistoricalOhlcv> GetHistoricalDailyOHLCV(string fsym, string tsym, string e = null,
            int? aggregate = null, int? limit = null,
            string toTs = null)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalDailyOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalHourlyOHLCV(string fsym, string tsym, string e = null,
            int? aggregate = null, int? limit = null,
            string toTs = null)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalHourlyOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalMinuteOHLCV(string fsym, string tsym, string e = null,
            int? aggregate = null, int? limit = null,
            string toTs = null)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalMinuteOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayOhlcvForATimestamp> GetHistoricalDayOhlcvForaTS(string fsym, string[] tsyms,
            string ts = null, string e = null,
            string calculationType = null)
        {
            return await GetAsync<HistoricalDayOhlcvForATimestamp>(
                    HistoricalDataApiUrls.HistoricalDayOhlcVts(fsym, tsyms, ts, e, calculationType))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayAveragePrice> GetHistoricalDayAveragePrice(string fsym, string tsym,
            string e = null, string avgType = null, string utcHourDiff = null, string toTs = null)
        {
            return await GetAsync<HistoricalDayAveragePrice>(
                    HistoricalDataApiUrls.HistoricalDayAveragePrice(fsym, tsym, e, avgType, utcHourDiff, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalDailyExchangeVolume(string tsym, string e = null,
            int? aggregate = null, int? limit = null, string toTs = null)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalDailyExchangeVolume(tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalHourlyExchangeVolume(string tsym, string e = null,
            int? aggregate = null, int? limit = null, string toTs = null)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalHourlyExchangeVolume(tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }
    }
}