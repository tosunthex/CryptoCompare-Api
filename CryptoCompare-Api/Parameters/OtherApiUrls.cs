﻿using System;
using System.Collections.Generic;
using CryptoCompare_Api.Services;

namespace CryptoCompare_Api.Parameters
{
    public static class OtherApiUrls
    {
        public static Uri CoinList()
        {
            return QueryStringService.AppendQueryString("all/coinlist", new Dictionary<string, string>());
        }

        public static Uri SocialStats(long id)
        {
            return QueryStringService.AppendQueryString("socialstats/", new Dictionary<string, string>
            {
                {"id", id.ToString()}
            }, false);
        }

        public static Uri MiningEquipment()
        {
            return QueryStringService.AppendQueryString("miningequipment/", new Dictionary<string, string>(), false);
        }
    }
}