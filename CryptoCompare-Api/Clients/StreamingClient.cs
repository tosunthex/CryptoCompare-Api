using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Streaming;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class StreamingClient:BaseApiClient,IStreamingClient

    {
        public StreamingClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<SubsWatchlist> GetSubsWatchList(string[] fsyms, string tsym)
        {
            return await GetAsync<SubsWatchlist>(StreamingApiUrls.SubsWatchlist(fsyms,tsym)).ConfigureAwait(false);
        }

        public async Task<CoinGeneralInfo> GetCoinGeneralInfo(string[] fsyms, string tsym)
        {
            return await GetAsync<CoinGeneralInfo>(StreamingApiUrls.CoinGeneralInfo(fsyms, tsym)).ConfigureAwait(false);
        }

        public async Task<SubsByPair> GetSubsByPair(string fsym, string[] tsyms)
        {
            return await GetAsync<SubsByPair>(StreamingApiUrls.SubsByPair(fsym, tsyms)).ConfigureAwait(false);
        }
    }
}