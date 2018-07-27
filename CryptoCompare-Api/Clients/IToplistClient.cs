using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Toplist;

namespace CryptoCompare_Api.Clients
{
    public interface IToplistClient
    {
        /// <summary>
        /// Get top exchanges by volume for a currency pair.
        /// The number of exchanges you get is the minimum of the limit you set (default 5) and the total number of exchanges available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym);

        /// <summary>
        /// Get top exchanges by volume for a currency pair.
        /// The number of exchanges you get is the minimum of the limit you set (default 5) and the total number of exchanges available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="limit">The number of data points to return</param>
        /// <returns></returns>
        Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym, int? limit);

        /// <summary>
        /// Get top exchanges by volume for a currency pair plus the full CCCAGG data.
        /// The number of exchanges you get is the minimum of the limit you set (default 5) and the total number of exchanges available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym);

        /// <summary>
        /// Get top exchanges by volume for a currency pair plus the full CCCAGG data.
        /// The number of exchanges you get is the minimum of the limit you set (default 5) and the total number of exchanges available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="limit">The number of data points to return</param>
        /// <returns></returns>
        Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym, int? limit);

        /// <summary>
        /// Get top coins by volume for the to currency. It returns volume24hto and total supply (where available).
        /// The number of coins you get is the minimum of the limit you set (default 50) and the total number of coins available
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym);

        /// <summary>
        /// Get top coins by volume for the to currency. It returns volume24hto and total supply (where available).
        /// The number of coins you get is the minimum of the limit you set (default 50) and the total number of coins available
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="limit">The number of data points to return</param>
        /// <returns></returns>
        Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym, int? limit);

        /// <summary>
        /// Get top pairs by volume for a currency (always uses our aggregated data).
        /// The number of pairs you get is the minimum of the limit you set (default 5) and the total number of pairs available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <returns></returns>
        Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym);

        /// <summary>
        /// Get top pairs by volume for a currency (always uses our aggregated data).
        /// The number of pairs you get is the minimum of the limit you set (default 5) and the total number of pairs available
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="limit">The number of data points to return</param>
        /// <returns></returns>
        Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym, int? limit);

        /// <summary>
        /// Get a number of top coins by their total volume accross all markets in the last 24 hours. Deafult value is first page (0) and the top 10 coins.
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym);

        /// <summary>
        /// Get a number of top coins by their total volume accross all markets in the last 24 hours. Deafult value is first page (0) and the top 10 coins.
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="page"></param>
        /// <returns></returns>
        Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym, int? limit, int? page);
    }
}