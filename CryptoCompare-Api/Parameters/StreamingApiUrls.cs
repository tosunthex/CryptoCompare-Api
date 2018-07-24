using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class StreamingApiUrls:BaseApiUrls
    {
        public static Uri SubsWatchlist(string[] fsyms, string tsym)
        {
            return QueryStringService.AppendQueryString("subsWatchlist",new Dictionary<string, string>
            {
                {"fsyms", string.Join(",", fsyms)},
                {"tsym", tsym}
            });
        }

        public static Uri CoinGeneralInfo(string[] fsyms,string tsym)
        {
            return QueryStringService.AppendQueryString("subsWatchlist",new Dictionary<string, string>
            {
                {"fsyms", string.Join(",", fsyms)},
                {"tsym", tsym}
            });
        }

        public static Uri SubsByPair(string fsym,string[] tsyms)
        {
            return QueryStringService.AppendQueryString("subs",new Dictionary<string, string>
            {
                {"fsym", fsym},
                {"tsyms", string.Join(",",tsyms)}
            });
        }
    }
}