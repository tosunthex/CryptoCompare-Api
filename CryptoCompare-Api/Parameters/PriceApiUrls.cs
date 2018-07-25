using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public static class PriceApiUrls
    {
        public static Uri MultipleSymbolFullData(string[] fsyms, string[] tsyms, bool? tryConversation, string e = null)
        {
            return CreatePriceUrl("pricemultifull", tryConversation, fsyms, tsyms, new[] {e});
        }

        public static Uri MultipleSymbolPrice(string[] fsyms, string[] tsyms, bool? tryConversation, string e = null)
        {
            return CreatePriceUrl("pricemulti", tryConversation, fsyms, tsyms, new[] {e});
        }

        public static Uri SingleSymbolPrice(string fsym, string[] tsyms, bool? tryConversation, string e = null)
        {
            return CreatePriceUrl("price", tryConversation, new[] {fsym}, tsyms, new[] {e});
        }

        public static Uri GenerateCustomAverage(string fsym, string[] tsyms, string[] e)
        {
            return CreatePriceUrl("generateAvg", null, new[] {fsym}, tsyms, e);
        }

        private static Uri CreatePriceUrl(string basePath, bool? tryConversation, string[] fsyms, string[] tsyms,
            string[] e)
        {
            switch (basePath)
            {
                case "price":
                {
                    return QueryStringService.AppendQueryString(basePath, new Dictionary<string, string>
                    {
                        {"fsym", string.Join(",", fsyms)},
                        {"tsyms", string.Join(",", tsyms)},
                        {"tryConversation", tryConversation.ToString()},
                        {"e", e == null ? null : string.Join(",", e)}
                    });
                    break;
                }
                case "generateAvg":
                {
                    return QueryStringService.AppendQueryString(basePath, new Dictionary<string, string>
                    {
                        {"fsym", string.Join(",", fsyms)},
                        {"tsym", string.Join(",", tsyms)},
                        {"tryConversation", tryConversation.ToString()},
                        {"e", e == null ? null : string.Join(",", e)}
                    });
                    break;
                }
                default:
                    return QueryStringService.AppendQueryString(basePath, new Dictionary<string, string>
                    {
                        {"fsyms", string.Join(",", fsyms)},
                        {"tsyms", string.Join(",", tsyms)},
                        {"tryConversation", tryConversation.ToString()},
                        {"e", e == null ? null : string.Join(",", e)}
                    });
            }
        }
    }
}