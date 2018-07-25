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

        public async Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym,
            int? limit = null)
        {
            return await GetAsync<TopExchangesVolumeDataByPair>(
                ToplistApiUrls.TopExchangesVolumeDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }

        public async Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym,
            int? limit = null)
        {
            return await GetAsync<TopExchangesFullDataByPair>(
                ToplistApiUrls.TopExchangesFullDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }

        public async Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym, int? limit = null)
        {
            return await GetAsync<ToplistByPairVolume>(ToplistApiUrls.ToplistByPairVolume(tsym, limit))
                .ConfigureAwait(false);
        }

        public async Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym, int? limit = null)
        {
            return await GetAsync<ToplistofTradingPair>(ToplistApiUrls.ToplistOfTradingPairs(fsym, limit))
                .ConfigureAwait(false);
        }

        public async Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym, int? limit = null,
            int? page = null)
        {
            return await GetAsync<ToplistByTotalVolume>(ToplistApiUrls.ToplistByTotalVolume(tsym, limit, page));
        }
    }
}