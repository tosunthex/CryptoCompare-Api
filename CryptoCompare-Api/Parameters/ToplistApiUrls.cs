using System;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class ToplistApiUrls:ApiUrls
    {
        public static Uri TopExchangesVolumeDataByPair(string fsym, string tsym, int? limit)
        {
            var fsymParameters = $"fsym={fsym}";
            var tsymParameters = $"tsym={tsym}";
            var limitParameters = QueryStringService.CreateUriParameter("limit", new[] {limit.ToString()});
            var url = QueryStringService.AppendQueryString("top/exchanges", fsymParameters, tsymParameters, limitParameters);
            return  new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri TopExchangesFullDataByPair(string fsym, string tsym, int? limit)
        {
            var fsymParameters = $"fsym={fsym}";
            var tsymParameters = $"tsym={tsym}";
            var limitParameters = QueryStringService.CreateUriParameter("limit", new[] { limit.ToString() });
            var url = QueryStringService.AppendQueryString("top/exchanges/full", fsymParameters, tsymParameters, limitParameters);
            return new Uri(BaseMinApiEndPoint, url);
        }

    }
}