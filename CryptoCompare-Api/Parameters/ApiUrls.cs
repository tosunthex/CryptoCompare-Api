using System;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class ApiUrls
    {
        private static readonly Uri BaseMinApiEndPoint =
            new Uri("https://min-api.cryptocompare.com/data/", UriKind.Absolute);
        
        public static readonly Uri SiteApiEndpoint = new Uri(
            "https://www.cryptocompare.com/api/data/",
            UriKind.Absolute);

//        private static readonly QueryStringService _queryStringService;

        public static Uri NewsFeeds()
        {
            return new Uri(BaseMinApiEndPoint,"news/feeds");
        }

        public static Uri NewsCategories()
        {
            return new Uri(BaseMinApiEndPoint, "news/categories");
        }

        public static Uri FeedsAndCategories()
        {
            return new Uri(BaseMinApiEndPoint, "news/feedsandcategories");
        }

        public static Uri News(string[] feeds, string[] categories, string[] excludeCategories,long? its, string lang, string sort)
        { 
            var feedsParam = feeds == null ? null : $"feeds={string.Join(",", feeds)}";
            var categoriesParam = categories == null ? null : $"categories={string.Join(",", categories)}";
            var excludeCategoriesParam = excludeCategories == null
                ? null
                : $"excludeCategories={string.Join(",", excludeCategories)}";
            var itsParameters = its == null ? null : its.ToString();
            var langParameters = string.IsNullOrWhiteSpace(lang) ? null : $"lang={lang}";
            var sortParameters = string.IsNullOrWhiteSpace(sort) ? null : $"sort={sort}";
            var url = new QueryStringService().AppendQueryString("v2/news/", feedsParam, categoriesParam,
                excludeCategoriesParam, itsParameters
                , langParameters, sortParameters);
            return new Uri(BaseMinApiEndPoint, url);
        }
    }
    
}