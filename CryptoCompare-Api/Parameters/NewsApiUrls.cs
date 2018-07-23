using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class NewsApiUrls:BaseApiUrls
    {
        public static Uri NewsFeeds()
        {
            return new QueryStringService("news/feeds").AppendQueryString(new Dictionary<string, string>());
        }

        public static Uri NewsCategories()
        {
            return new QueryStringService("news/categories").AppendQueryString(new Dictionary<string, string>());
        }

        public static Uri FeedsAndCategories()
        {
            return new QueryStringService("news/feedsandcategories").AppendQueryString(new Dictionary<string, string>());
        }

        public static Uri News(string[] feeds, string[] categories, string[] excludeCategories,long? its, string lang, string sort)
        { 
            
            return new QueryStringService("v2/news/").AppendQueryString(new Dictionary<string, string>
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