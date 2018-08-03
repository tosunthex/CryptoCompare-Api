using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Other;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class OtherClient : BaseApiClient, IOtherClient
    {
        public OtherClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Socialstat> GetSocialStat(long id)
        {
            return await GetAsync<Socialstat>(OtherApiUrls.SocialStats(id)).ConfigureAwait(false);
        }

        public async Task<Coinlist> GetCoinList()
        {
            return await GetAsync<Coinlist>(OtherApiUrls.CoinList()).ConfigureAwait(false);
        }

        public async Task<Miningequipment> GetMiningEquipment()
        {
            return await GetAsync<Miningequipment>(OtherApiUrls.MiningEquipment()).ConfigureAwait(false);
        }
    }
}