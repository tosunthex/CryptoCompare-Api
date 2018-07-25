using System;

namespace CryptoCompare_Api.Parameters
{
    public class BaseApiUrls
    {
        public static readonly Uri BaseMinApiEndPoint =
            new Uri("https://min-api.cryptocompare.com/data/", UriKind.Absolute);

        public static readonly Uri SiteApiEndpoint = new Uri(
            "https://www.cryptocompare.com/api/data/",
            UriKind.Absolute);
    }
}