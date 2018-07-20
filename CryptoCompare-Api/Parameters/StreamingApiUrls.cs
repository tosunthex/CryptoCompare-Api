using System;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class StreamingApiUrls:ApiUrls
    {
        public static Uri SubsWatchlist(string[] fsyms, string tsym)
        {
            var fsymsParameters = QueryStringService.CreateUriParameter("fsyms", fsyms);
            var tsymParameters = $"tsym={tsym}";
            var url = QueryStringService.AppendQueryString("subsWatchlist", fsymsParameters, tsymParameters);
            return new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri CoinGeneralInfo(string[] fsyms,string tsym)
        {
            var fsymsParameters = QueryStringService.CreateUriParameter("fsyms", fsyms);
            var tsymParameters = $"tsym={tsym}";
            var url = QueryStringService.AppendQueryString("coin/generalinfo", fsymsParameters, tsymParameters);
            return new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri SubsByPair(string fsym,string[] tsyms)
        {
            var fsymParameters = $"fsym={fsym}";
            var tsymParameters = QueryStringService.CreateUriParameter("tsyms", tsyms);

            var url = QueryStringService.AppendQueryString("subs", fsymParameters,tsymParameters);
            return new Uri(BaseMinApiEndPoint,url);
        }

        
    }
}