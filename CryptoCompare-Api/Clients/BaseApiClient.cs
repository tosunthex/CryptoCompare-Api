using System;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Clients
{
    /// <summary>
    /// Base Api Client
    /// </summary>
    public class BaseApiClient:IApiClient
    {
        private readonly HttpClient _httpClient;

        public BaseApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<TApiResponse> GetAsync<TApiResponse>(Uri resourceUri)
        {
            return this.SendRequestAsync<TApiResponse>(HttpMethod.Get, resourceUri);
        }

        public async Task<TApiResponse> SendRequestAsync<TApiResponse>(HttpMethod httpMethod, Uri resourseUri)
        {
            var jsonParserService = new JsonParserService();

            var response = await _httpClient.SendAsync(new HttpRequestMessage(httpMethod, resourseUri))
                .ConfigureAwait(false);

            return await jsonParserService.ParseResponse<TApiResponse>(response);
        }
    }
}