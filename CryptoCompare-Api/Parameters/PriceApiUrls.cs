﻿using System;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public class PriceApiUrls:ApiUrls
    {
        public static Uri MultipleSymbolFullData(string[] fsyms,string[] tsyms,bool? tryConversation,string e = null)
        {
            var url = CreatePriceUrl("pricemultifull", tryConversation, fsyms,tsyms,new string[]{e});
            return new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri MultipleSymbolPrice(string[] fsyms,string[] tsyms,bool? tryConversation,string e = null)
        {
            var url = CreatePriceUrl("pricemulti", tryConversation,fsyms,tsyms,new string[]{e});
            return new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri SingleSymbolPrice(string fsym,string[] tsyms,bool? tryConversation,string e = null)
        {
            var url = CreatePriceUrl("price", tryConversation,new string[]{fsym},tsyms,new string[]{e} );
            return new Uri(BaseMinApiEndPoint,url);
        }

        public static Uri GenerateCustomAverage(string fsym, string[] tsyms, string[] e)
        {
            var url = CreatePriceUrl("generateAvg", null,new string[]{fsym},tsyms,e );
            return new Uri(BaseMinApiEndPoint,url);
        }

        private static string CreatePriceUrl(string basePath, bool? tryConversation, string[] fsyms, string[] tsyms, string[] e)
        {
            var fsymsParameters = QueryStringService.CreateUriParameter("fsyms", fsyms);
            var tsymsParameters = QueryStringService.CreateUriParameter("tsyms", tsyms);
            var tryConversationParameters = tryConversation== false ? "tryConversation=false" : null;
            var eParameters = QueryStringService.CreateUriParameter("e", e);
            switch (basePath)
            {
                case "price":
                {
                    fsymsParameters = QueryStringService.CreateUriParameter("fsym", fsyms);
                        break;
                }
                case "generateAvg":
                {
                    fsymsParameters = QueryStringService.CreateUriParameter("fsym", fsyms);
                    tsymsParameters = QueryStringService.CreateUriParameter("tsym", tsyms);
                        break;
                }   
            }
            
            return QueryStringService.AppendQueryString(basePath, tryConversationParameters, fsymsParameters,
                tsymsParameters,eParameters);
        }
        
    }
}