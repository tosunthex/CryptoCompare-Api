using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public static class NewsApiUrls
    {
        public static Uri NewsFeeds()
        {
            return QueryStringService.AppendQueryString("news/feeds",new Dictionary<string, string>());
        }

        public static Uri NewsCategories()
        {
            return QueryStringService.AppendQueryString("news/categories",new Dictionary<string, string>());
        }

        public static Uri FeedsAndCategories()
        {
            return QueryStringService.AppendQueryString("news/feedsandcategories",new Dictionary<string, string>());
        }

        public static Uri News(string[] feeds, string[] categories, string[] excludeCategories,long? its, string lang, string sort)
        { 
            
            return QueryStringService.AppendQueryString("v2/news/",new Dictionary<string, string>
            {
                {"feeds", feeds!= null ? string.Join(",",feeds): null },
                {"categories", categories!= null ? string.Join(",",categories): null },
                {"excludeCategories", excludeCategories != null ? string.Join(",",excludeCategories): null},
                {"its",its.ToString()},
                {"lang",lang},
                {"sort", sort },
            });
        }
    }
}