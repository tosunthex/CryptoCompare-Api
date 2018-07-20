using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Price;

namespace CryptoCompare_Api.Clients
{
    public interface IPriceClient
    {
        /// <summary>
        /// Get all the current trading info (price, vol, open, high, low etc) of any list of cryptocurrencies in any other currency that you need.
        /// If the crypto does not trade directly into the toSymbol requested, BTC will be used for conversion.
        /// This API also returns Display values for all the fields. If the oposite pair trades we invert it (eg.: BTC-XMR)
        /// </summary>
        /// <param name="tryConversion">If set to false, it will try to get only direct trading values</param>
        /// <param name="fsyms">Comma separated cryptocurrency symbols list [Max character length: 300]</param>
        /// <param name="tsyms">Comma separated cryptocurrency symbols list to convert into [Max character length: 100]</param>
        /// <param name="e">The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length: 30]</param>
        /// <returns></returns>
        Task<MultipleSymbolFullData> GetMultipleSymbolFullData(string[] fsyms, string[] tsyms,bool? tryConversion=null,
            string e = null);
        
        /// <summary>
        /// Get the multiple price of any cryptocurrencies in any other currency that you need.
        /// </summary>
        /// <param name="fsyms">Comma separated cryptocurrency symbols list [Max character length: 300]</param>
        /// <param name="tsyms">Comma separated cryptocurrency symbols list to convert into [Max character length: 100]</param>
        /// <param name="tryConversion">If set to false, it will try to get only direct trading values</param>
        /// <param name="e">The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length: 30]</param>
        /// <returns></returns>
        Task<MultipleSymbolPrice> GetMultipleSymbolPrice(string[] fsyms, string[] tsyms, bool? tryConversion = null,
            string e = null);
        /// <summary>
        /// Get the current price of any cryptocurrency in any other currency that you need.
        /// If the crypto does not trade directly into the toSymbol requested, BTC will be used for conversion.
        /// If the oposite pair trades we invert it (eg.: BTC-XMR)
        /// </summary>
        /// <param name="fsyms">Comma separated cryptocurrency symbols list [Max character length: 300]</param>
        /// <param name="tsyms">Comma separated cryptocurrency symbols list to convert into [Max character length: 100]</param>
        /// <param name="tryConversion">If set to false, it will try to get only direct trading values</param>
        /// <param name="e">The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length: 30]</param>
        /// <returns></returns>
        Task<SingleSymbolPrice> GetSingleSymbolPrice(string fsym, string[] tsyms, bool? tryConversion = null,
            string e = null);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fsym"></param>
        /// <param name="tsyms"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        Task<GenerateCustomAverage> GetGenerateCustomAverage(string fsym, string[] tsyms, string[] e);
    }
}