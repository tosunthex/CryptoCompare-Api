using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Other;

namespace CryptoCompare_Api.Clients
{
    public interface IOtherClient
    {
        Task<Socialstat> GetSocialStat(int id);
        Task<Coinlist> GetCoinList();
        Task<Miningequipment> GetMiningEquipment();
    }
}