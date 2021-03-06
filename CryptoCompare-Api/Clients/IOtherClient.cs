﻿using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Other;

namespace CryptoCompare_Api.Clients
{
    public interface IOtherClient
    {
        /// <summary>
        ///     Get CryptoCompare website, Facebook, code repository, Twitter and Reddit data for coins.
        ///     If called with the id of a cryptopian you just get data from our website that
        ///     is available to the public
        /// </summary>
        /// <param name="id">The id of the coin/exchange you want social data for</param>
        /// <returns></returns>
        Task<Socialstat> GetSocialStat(long id);

        /// <summary>
        ///     Get general info for all the coins available on the website.
        /// </summary>
        /// <returns></returns>
        Task<Coinlist> GetCoinList();

        /// <summary>
        ///     Used to get all the mining equipment available on the website. It returns an array
        ///     of mining equipment objects
        /// </summary>
        /// <returns></returns>
        Task<Miningequipment> GetMiningEquipment();

        /// <summary>
        /// Returns all the exchanges that CryptoCompare has integrated with.
        /// </summary>
        /// <returns></returns>
        Task<ExchangesListResponse> GetAllExchanges();

        /// <summary>
        /// Returns all the exchanges that CryptoCompare has integrated with and their status,
        /// including whether or not they are excluded from pricing and volumes.
        /// </summary>
        /// <returns></returns>
        Task<CccaggExchanges> GetCccaggExchanges();

        //Task<RateLimitStats> GetRateLimit(string rateLimit);
    }
}