using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    
    public class HistoricalDataApiUrls
    {

        public static Uri HistoricalDailyOhlcv(string fsym,string tsym,string e,int? aggregate,int? limit,string toTs)
        {
            return CreateHistoricalUrl("histoday",fsym, tsym, e, aggregate, limit, toTs);
        }

        public static Uri HistoricalHourlyOhlcv(string fsym, string tsym, string e, int? aggregate, int? limit,
            string toTs)
        {
            return CreateHistoricalUrl("histohour",fsym, tsym, e, aggregate, limit, toTs);
        }
        public static Uri HistoricalMinuteOhlcv(string fsym, string tsym, string e, int? aggregate, int? limit,
            string toTs)
        {
            return CreateHistoricalUrl("histominute",fsym, tsym, e, aggregate, limit, toTs);
        }

        public static Uri HistoricalDayOhlcVts(string fsym, string[] tsyms,string ts, string e, string calculationType)
        {
            return QueryStringService.AppendQueryString("pricehistorical",new Dictionary<string, string>
            {
                {"fsym",fsym},
                {"tsyms",string.Join(",",tsyms)},
                {"e",e},
                {"calculationType",calculationType}
            });
        }

        public static Uri HistoricalDayAveragePrice(string fsym, string tsym, string e, string avgType,
            string utcHourDiff, string toTs)
        {
            
            return QueryStringService.AppendQueryString("dayAvg",new Dictionary<string, string>
            {
                {"fsym",fsym},
                {"tsym",tsym},
                {"e",e},
                {"avgType",avgType},
                {"utcHourDiff",utcHourDiff},
                {"toTs", toTs}
            });
        }
        
        public static Uri HistoricalDailyExchangeVolume(string tsym, string e, int? aggregate,
            int? limit, string toTs)
        {
            
            return QueryStringService.AppendQueryString("exchange/histoday",new Dictionary<string, string>
            {
                {"tsym",tsym},
                {"e",e},
                {"aggregate",aggregate.ToString()},
                {"limit",limit.ToString()},
                {"toTs", toTs}
            });
        }
        public static Uri HistoricalHourlyExchangeVolume(string tsym, string e, int? aggregate,
            int? limit, string toTs)
        {
            
            return QueryStringService.AppendQueryString("exchange/histohour",new Dictionary<string, string>
            {
                {"tsym",tsym},
                {"e",e},
                {"aggregate",aggregate.ToString()},
                {"limit",limit.ToString()},
                {"toTs", toTs}
            });
        }
        
        private static Uri CreateHistoricalUrl(string url = null, string fsym = null, string tsym = null,
            string e = null, int? aggregate = null, int? limit = null,
            string toTs=null)
        {
            
            return QueryStringService.AppendQueryString(url,new Dictionary<string, string>
            {
                {"fsym",fsym},
                {"tsym",tsym},
                {"e",e},
                {"aggregate",aggregate.ToString()},
                {"limit",limit.ToString()},
                {"toTs", toTs}
            });
        }
    }
}