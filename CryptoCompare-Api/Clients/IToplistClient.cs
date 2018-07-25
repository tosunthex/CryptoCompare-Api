using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Toplist;

namespace CryptoCompare_Api.Clients
{
    public interface IToplistClient
    {
        Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym, int? limit = null);
        Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym, int? limit = null);
        Task<ToplistByPairVolume> GetToplistByPairVolume(string tsym, int? limit = null);
        Task<ToplistofTradingPair> GetToplistOfTradingPairs(string fsym, int? limit = null);
        Task<ToplistByTotalVolume> GetToplistByTotalVolume(string tsym, int? limit = null, int? page = null);
    }
}