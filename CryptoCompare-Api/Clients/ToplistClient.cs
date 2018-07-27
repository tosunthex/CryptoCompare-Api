using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Toplist;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class ToplistClient : BaseApiClient, IToplistClient
    {
        public ToplistClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym)
        {
            return await GetAsync<TopExchangesVolumeDataByPair>(
                ToplistApiUrls.TopExchangesVolumeDataByPair(fsym, tsym, null)).ConfigureAwait(false);
        }

        public async Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym,
            int? limit)
        {
            return await GetAsync<TopExchangesVolumeDataByPair>(
                ToplistApiUrls.TopExchangesVolumeDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }

        public async Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym)
        {
            return await GetAsync<TopExchangesFullDataByPair>(
                ToplistApiUrls.TopExchangesFullDataByPair(fsym, tsym, null)).ConfigureAwait(false);
        }

        public async Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym,
            int? limit)
        {
            return await GetAsync<TopExchangesFullDataByPair>(
                ToplistApiUrls.TopExchangesFullDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }

        public async Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym)
        {
            return await GetAsync<ToplistByPairVolume>(ToplistApiUrls.ToplistByPairVolume(tsym, null))
                .ConfigureAwait(false);
        }

        public async Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym, int? limit)
        {
            return await GetAsync<ToplistByPairVolume>(ToplistApiUrls.ToplistByPairVolume(tsym, limit))
                .ConfigureAwait(false);
        }

        public async Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym)
        {
            return await GetAsync<ToplistofTradingPair>(ToplistApiUrls.ToplistOfTradingPairs(fsym, null))
                .ConfigureAwait(false);
        }

        public async Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym, int? limit)
        {
            return await GetAsync<ToplistofTradingPair>(ToplistApiUrls.ToplistOfTradingPairs(fsym, limit))
                .ConfigureAwait(false);
        }

        public async Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym)
        {
            return await GetAsync<ToplistByTotalVolume>(ToplistApiUrls.ToplistByTotalVolume(tsym, null, null));
        }

        public async Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym, int? limit,
            int? page)
        {
            return await GetAsync<ToplistByTotalVolume>(ToplistApiUrls.ToplistByTotalVolume(tsym, limit, page));
        }
    }
}