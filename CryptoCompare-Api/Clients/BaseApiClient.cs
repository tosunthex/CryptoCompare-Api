using System;
using System.Net.Http;
using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Clients
{
    /// <summary>
    ///     Base Api Client
    /// </summary>
    public class BaseApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public BaseApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<TApiResponse> GetAsync<TApiResponse>(Uri resourceUri)
        {
            return SendRequestAsync<TApiResponse>(HttpMethod.Get, resourceUri);
        }

        public async Task<TApiResponse> SendRequestAsync<TApiResponse>(HttpMethod httpMethod, Uri resourseUri)
        {
            var response = await _httpClient.SendAsync(new HttpRequestMessage(httpMethod, resourseUri))
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<TApiResponse>(responseContent);
            }
            catch (Exception e)
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                
                var errorMessage =
                    $"{errorResponse.Type} : {errorResponse.Message} {errorResponse.ErrorSummary} {errorResponse.Path} {e.Message}";
                throw new HttpRequestException(errorMessage);
            }
        }
    }
}