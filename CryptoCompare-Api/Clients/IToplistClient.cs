using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Toplist;

namespace CryptoCompare_Api.Clients
{
    public interface IToplistClient
    {
        Task<TopExchangesVolumeDataByPair> GetTopExchangesVolumeDataByPair(string fsym, string tsym,int? limit = null);
        Task<TopExchangesFullDataByPair> GetTopExchangesFullDataByPair(string fsym, string tsym, int? limit = null);
    }
}