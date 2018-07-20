using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Toplist;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class ToplistClient:BaseApiClient,IToplistClient
    {
        public ToplistClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym, int? limit=null)
        {
            return await GetAsync<TopExchangesVolumeDataByPair>(
                ToplistApiUrls.TopExchangesVolumeDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }

        public async Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym, int? limit = null)
        {
            return await GetAsync<TopExchangesFullDataByPair>(
                ToplistApiUrls.TopExchangesFullDataByPair(fsym, tsym, limit)).ConfigureAwait(false);
        }
    }
}