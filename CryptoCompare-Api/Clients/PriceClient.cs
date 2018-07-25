using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Price;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class PriceClient : BaseApiClient, IPriceClient
    {
        public PriceClient(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<MultipleSymbolFullData> GetMultipleSymbolFullData(string[] fsyms, string[] tsyms,
            bool? tryConversion = null, string e = null)
        {
            return await GetAsync<MultipleSymbolFullData>(
                    PriceApiUrls.MultipleSymbolFullData(fsyms, tsyms, tryConversion, e))
                .ConfigureAwait(false);
        }

        public async Task<MultipleSymbolPrice> GetMultipleSymbolPrice(string[] fsyms, string[] tsyms,
            bool? tryConversion = null, string e = null)
        {
            return await GetAsync<MultipleSymbolPrice>(PriceApiUrls.MultipleSymbolPrice(fsyms, tsyms, tryConversion, e))
                .ConfigureAwait(false);
        }

        public async Task<SingleSymbolPrice> GetSingleSymbolPrice(string fsym, string[] tsyms,
            bool? tryConversion = null, string e = null)
        {
            return await GetAsync<SingleSymbolPrice>(PriceApiUrls.SingleSymbolPrice(fsym, tsyms, tryConversion, e));
        }

        public async Task<GenerateCustomAverage> GetGenerateCustomAverage(string fsym, string[] tsyms, string[] e)
        {
            return await GetAsync<GenerateCustomAverage>(PriceApiUrls.GenerateCustomAverage(fsym, tsyms, e));
        }
    }
}