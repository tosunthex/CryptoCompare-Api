﻿using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public static class PriceApiUrls
    {
        public static Uri MultipleSymbolFullData(string[] fsyms, string[] tsyms, bool? tryConversation, string e)
        {
            var tryCon = tryConversation ?? false;
            return CreatePriceUrl("pricemultifull", tryCon, fsyms, tsyms, new[] {e});
        }

        public static Uri MultipleSymbolPrice(string[] fsyms, string[] tsyms, bool? tryConversation, string e)
        {
            var tryCon = tryConversation ?? false;
            return CreatePriceUrl("pricemulti", tryCon, fsyms, tsyms, new[] {e});
        }

        public static Uri SingleSymbolPrice(string fsym, string[] tsyms, bool? tryConversation, string e)
        {
            var tryCon = tryConversation ?? false;
            return CreatePriceUrl("price", tryCon, new[] {fsym}, tsyms, new[] {e});
        }

        public static Uri GenerateCustomAverage(string fsym, string[] tsyms, string[] e)
        {
            return CreatePriceUrl("generateAvg", false, new[] {fsym}, tsyms, e);
        }

        private static Uri CreatePriceUrl(string basePath, bool tryConversation, string[] fsyms, string[] tsyms,
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
                        {"tryConversation", tryConversation == false ? null : "true"},
                        {"e", e == null ? null : string.Join(",", e)}
                    });
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