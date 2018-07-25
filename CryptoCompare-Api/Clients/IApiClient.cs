using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoCompare_Api.Clients
{
    public interface IApiClient
    {
        /// <summary>
        ///     Sends an API request async using GET Method
        /// </summary>
        /// <param name="resourceUri">The resouce uri path</param>
        /// <typeparam name="TApiResponse">Response type of method</typeparam>
        /// <returns>Asyncronous result turns by TApiResouce</returns>
        Task<TApiResponse> GetAsync<TApiResponse>(Uri resourceUri);

        /// <summary>
        ///     Sends an API request async
        /// </summary>
        /// <param name="httpMethod">Http Method</param>
        /// <param name="resourseUri">The resouce uri path</param>
        /// <typeparam name="TApiResponse">Response type of method</typeparam>
        /// <returns>Asyncronous result turns by TApiResouce</returns>
        Task<TApiResponse> SendRequestAsync<TApiResponse>(HttpMethod httpMethod, Uri resourseUri);
    }
}