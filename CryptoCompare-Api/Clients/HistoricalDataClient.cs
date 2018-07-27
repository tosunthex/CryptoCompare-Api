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

        public async Task<HistoricalOhlcv> GetHistoricalDailyOhlcv(string fsym, string tsym, string e,
            int? aggregate, int? limit,string toTs = null)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalDailyOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalDailyOhlcv(string fsym, string tsym)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalDailyOhlcv(fsym, tsym, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalHourlyOhlcv(string fsym, string tsym, string e, int? aggregate,
            int? limit, string toTs)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalHourlyOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalHourlyOhlcv(string fsym, string tsym)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalHourlyOhlcv(fsym, tsym, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalMinuteOhlcv(string fsym, string tsym, string e,
            int? aggregate, int? limit, string toTs)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalMinuteOhlcv(fsym, tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalOhlcv> GetHistoricalMinuteOhlcv(string fsym, string tsym)
        {
            return await GetAsync<HistoricalOhlcv>(
                    HistoricalDataApiUrls.HistoricalMinuteOhlcv(fsym, tsym, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayOhlcvForATimestamp> GetHistoricalDayOhlcvForaTs(string fsym, string[] tsyms, string ts,
            string e, string calculationType)
        {
            return await GetAsync<HistoricalDayOhlcvForATimestamp>(
                    HistoricalDataApiUrls.HistoricalDayOhlcVts(fsym, tsyms, ts, e, calculationType))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayOhlcvForATimestamp> GetHistoricalDayOhlcvForaTs(string fsym, string[] tsyms)
        {
            return await GetAsync<HistoricalDayOhlcvForATimestamp>(
                    HistoricalDataApiUrls.HistoricalDayOhlcVts(fsym, tsyms, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayAveragePrice> GetHistoricalDayAveragePrice(string fsym, string tsym, string e,
            string avgType, string utcHourDiff, string toTs)
        {
            return await GetAsync<HistoricalDayAveragePrice>(
                    HistoricalDataApiUrls.HistoricalDayAveragePrice(fsym, tsym, e, avgType, utcHourDiff, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalDayAveragePrice> GetHistoricalDayAveragePrice(string fsym, string tsym)
        {
            return await GetAsync<HistoricalDayAveragePrice>(
                    HistoricalDataApiUrls.HistoricalDayAveragePrice(fsym, tsym, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalDailyExchangeVolume(string tsym, string e, int? aggregate,
            int? limit, string toTs)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalDailyExchangeVolume(tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalDailyExchangeVolume(string tsym)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalDailyExchangeVolume(tsym, null, null, null, null))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalHourlyExchangeVolume(string tsym, string e, int? aggregate,
            int? limit, string toTs)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalHourlyExchangeVolume(tsym, e, aggregate, limit, toTs))
                .ConfigureAwait(false);
        }

        public async Task<HistoricalExchangeVolume> GetHistoricalHourlyExchangeVolume(string tsym)
        {
            return await GetAsync<HistoricalExchangeVolume>(
                    HistoricalDataApiUrls.HistoricalHourlyExchangeVolume(tsym, null, null, null, null))
                .ConfigureAwait(false);
        }
    }
}