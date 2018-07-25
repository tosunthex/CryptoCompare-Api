using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.Streaming;

namespace CryptoCompare_Api.Clients
{
    public interface IStreamingClient
    {
        /// <summary>
        ///     Get combinations of subs and pricing info in order to know what needs to be streamed and how to connect to the
        ///     streamers. The possible responses for Conversion are: not_needed, direct, invert, multiply, divide,
        ///     invert_multiply, invert_divide
        ///     For not_needed - it means you asked for one symbol to the same symbol. You should just use the value you have, no
        ///     need for streaming or conversion.
        ///     For direct - SubBase + Market + ~ + CurrencyFrom + ~ + CurrencyTo
        ///     For invert - 1 / SubBase + Market + ~ + CurrencyTo + ~ + CurrencyFrom
        ///     For multiply - SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol * SubBase + Market + ~ + ConversionSymbol
        ///     + ~ + CurrencyTo
        ///     For divide - SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol / SubBase + Market + ~ + CurrencyTo + ~ +
        ///     ConversionSymbol
        ///     For invert_muliply - 1 / (SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol * SubBase + Market + ~ +
        ///     ConversionSymbol + ~ + CurrencyTo)
        ///     For invert_divide - SubBase + Market + ~ + ConversionSymbol + ~ + CurrencyTo / SubBase + Market + ~ +
        ///     ConversionSymbol + ~ + CurrencyFrom
        /// </summary>
        /// <param name="fsyms">REQUIRED Comma separated cryptocurrency symbols list [Max character length: 3000]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<SubsWatchlist> GetSubsWatchList(string[] fsyms, string tsym);

        /// <summary>
        ///     Get combinations of subs and pricing info in order to know what needs to be streamed and how to connect to the
        ///     streamers. The possible responses for Conversion are: not_needed, direct, invert, multiply, divide,
        ///     invert_multiply, invert_divide
        ///     For not_needed - it means you asked for one symbol to the same symbol. You should just use the value you have, no
        ///     need for streaming or conversion.
        ///     For direct - SubBase + Market + ~ + CurrencyFrom + ~ + CurrencyTo
        ///     For invert - 1 / SubBase + Market + ~ + CurrencyTo + ~ + CurrencyFrom
        ///     For multiply - SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol * SubBase + Market + ~ + ConversionSymbol
        ///     + ~ + CurrencyTo
        ///     For divide - SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol / SubBase + Market + ~ + CurrencyTo + ~ +
        ///     ConversionSymbol
        ///     For invert_muliply - 1 / (SubBase + Market + ~ + CurrencyFrom + ~ + ConversionSymbol * SubBase + Market + ~ +
        ///     ConversionSymbol + ~ + CurrencyTo)
        ///     For invert_divide - SubBase + Market + ~ + ConversionSymbol + ~ + CurrencyTo / SubBase + Market + ~ +
        ///     ConversionSymbol + ~ + CurrencyFrom
        /// </summary>
        /// <param name="fsyms">REQUIRED Comma separated cryptocurrency symbols list [Max character length: 3000]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<CoinGeneralInfo> GetCoinGeneralInfo(string[] fsyms, string tsym);

        /// <summary>
        ///     Get all the available streamer subscription channels for the requested pairs.
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsyms">Comma separated cryptocurrency symbols list to convert into [Max character length: 100]</param>
        /// <returns></returns>
        Task<SubsByPair> GetSubsByPair(string fsym, string[] tsyms);
    }
}