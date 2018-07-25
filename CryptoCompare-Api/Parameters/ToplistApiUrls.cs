using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class ToplistApiUrls
    {
        public static Uri TopExchangesVolumeDataByPair(string fsym, string tsym, int? limit)
        {
            return QueryStringService.AppendQueryString("top/exchanges", new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri TopExchangesFullDataByPair(string fsym, string tsym, int? limit)
        {
            return QueryStringService.AppendQueryString("top/exchanges/full", new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri ToplistByPairVolume(string tsym, int? limit)
        {
            return QueryStringService.AppendQueryString("top/volumes", new Dictionary<string, string>
            {
                {"tsym", tsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri ToplistOfTradingPairs(string fsym, int? limit)
        {
            return QueryStringService.AppendQueryString("top/pairs", new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"limit", limit.ToString()}
            });
        }

        public static Uri ToplistByTotalVolume(string tsym, int? limit, int? page)
        {
            return QueryStringService.AppendQueryString("top/totalvol", new Dictionary<string, string>
            {
                {"tsym", tsym},
                {"page", page.ToString()},
                {"limit", limit.ToString()}
            });
        }
    }
}