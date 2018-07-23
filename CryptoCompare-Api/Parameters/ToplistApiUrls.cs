using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class ToplistApiUrls
    {
        public static Uri TopExchangesVolumeDataByPair(string fsym, string tsym, int? limit)
        {
            return new QueryStringService("top/exchanges").AppendQueryString(new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri TopExchangesFullDataByPair(string fsym, string tsym, int? limit)
        {
            
            return new QueryStringService("top/exchanges/full").AppendQueryString(new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri ToplistByPairVolume(string tsym,int? limit)
        {
            return new QueryStringService("top/volumes").AppendQueryString(new Dictionary<string, string>
            {
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }
        public static Uri ToplistOfTradingPairs(string fsym, int? limit)
        {
            return new QueryStringService("top/pairs").AppendQueryString(new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"limit", limit.ToString()}
            });
        }
        public static Uri ToplistByTotalVolume(string tsym, int? limit, int? page)
        {
            return new QueryStringService("top/totalvol").AppendQueryString(new Dictionary<string, string>
            {
                {"tsym", tsym},
                {"page", page.ToString()},
                {"limit", limit.ToString()}
            });
        }
    }
}