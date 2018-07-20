using System;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class NewsApiUrls:ApiUrls
    {
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
            var feedsParam = QueryStringService.CreateUriParameter("feeds",feeds);
            var categoriesParam = QueryStringService.CreateUriParameter("categories", categories);
            var excludeCategoriesParam = QueryStringService.CreateUriParameter("excludeCategories", excludeCategories);
            var itsParameters = its == null ? null : its.ToString();
            var langParameters = QueryStringService.CreateUriParameter("lang",new []{lang});
            var sortParameters = QueryStringService.CreateUriParameter("sort", new[] { sort });
            var url = QueryStringService.AppendQueryString("v2/news/", feedsParam, categoriesParam,
                excludeCategoriesParam, itsParameters
                , langParameters, sortParameters);
            return new Uri(BaseMinApiEndPoint, url);
        }
    }
}