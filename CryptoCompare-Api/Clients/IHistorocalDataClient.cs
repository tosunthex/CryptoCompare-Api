using System.Threading.Tasks;
using CryptoCompare_Api.Models.Responses.HistoricalData;

namespace CryptoCompare_Api.Clients
{
    public interface IHistorocalDataClient
    {
        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the daily historical data.The values are based on
        ///     00:00 GMT time.It uses BTC conversion if data is not available because the coin is not trading in the
        ///     specified currency.
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="aggregate">
        ///     Time period to aggregate the data over (for daily it's days, for hourly it's hours and for
        ///     minute histo it's minutes)
        /// </param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalOhlcv> GetHistoricalDailyOhlcv(string fsym, string tsym, string e,
            int? aggregate, int? limit, string toTs);
        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the daily historical data.The values are based on
        ///     00:00 GMT time.It uses BTC conversion if data is not available because the coin is not trading in the
        ///     specified currency.
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<HistoricalOhlcv> GetHistoricalDailyOhlcv(string fsym, string tsym);

        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the hourly historical data. It uses BTC conversion
        ///     if data is not available because the coin is not trading in the specified currency
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="aggregate">
        ///     Time period to aggregate the data over (for daily it's days, for hourly it's hours and for
        ///     minute histo it's minutes)
        /// </param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalOhlcv> GetHistoricalHourlyOhlcv(string fsym, string tsym, string e,int? aggregate, 
            int? limit, string toTs);

        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the hourly historical data. It uses BTC conversion
        ///     if data is not available because the coin is not trading in the specified currency
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<HistoricalOhlcv> GetHistoricalHourlyOhlcv(string fsym, string tsym);

        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the each minute historical data. This data is only
        ///     stored for 7 days, if you need more, use the hourly or daily path.
        ///     It uses BTC conversion if data is not available because the coin is not trading in the specified currency.
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="aggregate">
        ///     Time period to aggregate the data over (for daily it's days, for hourly it's hours and for
        ///     minute histo it's minutes)
        /// </param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalOhlcv> GetHistoricalMinuteOhlcv(string fsym, string tsym, string e,
            int? aggregate, int? limit, string toTs);

        /// <summary>
        ///     Get open, high, low, close, volumefrom and volumeto from the each minute historical data. This data is only
        ///     stored for 7 days, if you need more, use the hourly or daily path.
        ///     It uses BTC conversion if data is not available because the coin is not trading in the specified currency.
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        Task<HistoricalOhlcv> GetHistoricalMinuteOhlcv(string fsym, string tsym);

        /// <summary>
        ///     Get the price of any cryptocurrency in any other currency that you need at a given timestamp. The price
        ///     comes from the daily info - so it would be the price at the end of the day GMT based on the requested TS.
        ///     If the crypto does not trade directly into the toSymbol requested, BTC will be used for conversion. Tries
        ///     to get direct trading pair data, if there is none or it is more than 10 days before the ts requested, it
        ///     uses BTC conversion. If the oposite pair trades we invert it (eg.: BTC-XMR)
        ///     The calculation types are:
        ///     Close - a Close of the day close price
        ///     MidHighLow - the average between the 24 H high and low
        ///     VolFVolT - the total volume to / the total volume from
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsyms">REQUIRED Comma separated cryptocurrency symbols list to convert into [Max character length: 30]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="ts">The unix timestamp of interest</param>
        /// <param name="calculationType">
        ///     Type of average to calculate (Close - a Close of the day close price,
        ///     MidHighLow - the average between the 24 H high and low, VolFVolT - the total volume to / the total volume
        ///     from) [Max character length: 30]
        /// </param>
        /// <returns></returns>
        Task<HistoricalDayOhlcvForATimestamp> GetHistoricalDayOhlcvForaTs(string fsym, string[] tsyms, string ts,
            string e,string calculationType);

        /// <summary>
        ///     Get the price of any cryptocurrency in any other currency that you need at a given timestamp. The price
        ///     comes from the daily info - so it would be the price at the end of the day GMT based on the requested TS.
        ///     If the crypto does not trade directly into the toSymbol requested, BTC will be used for conversion. Tries
        ///     to get direct trading pair data, if there is none or it is more than 10 days before the ts requested, it
        ///     uses BTC conversion. If the oposite pair trades we invert it (eg.: BTC-XMR)
        ///     The calculation types are:
        ///     Close - a Close of the day close price
        ///     MidHighLow - the average between the 24 H high and low
        ///     VolFVolT - the total volume to / the total volume from
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsyms">REQUIRED Comma separated cryptocurrency symbols list to convert into [Max character length: 30]</param>
        /// <returns></returns>
        Task<HistoricalDayOhlcvForATimestamp> GetHistoricalDayOhlcvForaTs(string fsym, string[] tsyms);

        /// <summary>
        ///     Get day average price. The values are based on hourly vwap data and the average can be calculated in different
        ///     ways. It uses BTC conversion if data is not available because the coin is not trading in the specified currency. If
        ///     tryConversion is set to false it will give you the direct data. If no toTS is given it will automatically do the
        ///     current day. Also for different timezones use the UTCHourDiff param
        ///     The calculation types are:
        ///     HourVWAP - a VWAP of the hourly close price
        ///     MidHighLow - the average between the 24 H high and low.
        ///     VolFVolT - the total volume from / the total volume to (only avilable with tryConversion set to false so only for
        ///     direct trades but the value should be the most accurate average day price)
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="avgType">
        ///     Type of average to calculate (HourVWAP - a HourVWAP of hourly price, MidHighLow - the average
        ///     between the 24 H high and low, VolFVolT - the total volume to / the total volume from) [Max character length: 30]
        /// </param>
        /// <param name="utcHourDiff">
        ///     By deafult it does UTC, if you want a different time zone just pass the hour difference. For
        ///     PST you would pass -8 for example.
        /// </param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalDayAveragePrice> GetHistoricalDayAveragePrice(string fsym, string tsym, string e,
            string avgType,string utcHourDiff, string toTs);
        /// <summary>
        ///     Get day average price. The values are based on hourly vwap data and the average can be calculated in different
        ///     ways. It uses BTC conversion if data is not available because the coin is not trading in the specified currency. If
        ///     tryConversion is set to false it will give you the direct data. If no toTS is given it will automatically do the
        ///     current day. Also for different timezones use the UTCHourDiff param
        ///     The calculation types are:
        ///     HourVWAP - a VWAP of the hourly close price
        ///     MidHighLow - the average between the 24 H high and low.
        ///     VolFVolT - the total volume from / the total volume to (only avilable with tryConversion set to false so only for
        ///     direct trades but the value should be the most accurate average day price)
        /// </summary>
        /// <param name="fsym">REQUIRED The cryptocurrency symbol of interest [Max character length: 10]</param>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<HistoricalDayAveragePrice> GetHistoricalDayAveragePrice(string fsym, string tsym);

        /// <summary>
        ///     Get total volume from the daily historical exchange data.The values are based on 00:00 GMT time. We store the data
        ///     in BTC and we multiply by the BTC-tsym value
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="aggregate">
        ///     Time period to aggregate the data over (for daily it's days, for hourly it's hours and for
        ///     minute histo it's minutes)
        /// </param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalExchangeVolume> GetHistoricalDailyExchangeVolume(string tsym, string e,int? aggregate, int? limit, string toTs);

        /// <summary>
        ///     Get total volume from the daily historical exchange data.The values are based on 00:00 GMT time. We store the data
        ///     in BTC and we multiply by the BTC-tsym value
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<HistoricalExchangeVolume> GetHistoricalDailyExchangeVolume(string tsym);

        /// <summary>
        ///     Get total volume from the hourly historical exchange data.We store the data in BTC and we multiply by the BTC-tsym
        ///     value
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <param name="e">
        ///     The exchange to obtain data from (our aggregated average - CCCAGG - by default) [Max character length:
        ///     30]
        /// </param>
        /// <param name="aggregate">
        ///     Time period to aggregate the data over (for daily it's days, for hourly it's hours and for
        ///     minute histo it's minutes)
        /// </param>
        /// <param name="limit">The number of data points to return</param>
        /// <param name="toTs">Last unix timestamp to return data for</param>
        /// <returns></returns>
        Task<HistoricalExchangeVolume> GetHistoricalHourlyExchangeVolume(string tsym, string e,int? aggregate, int? limit, string toTs);

        /// <summary>
        ///     Get total volume from the hourly historical exchange data.We store the data in BTC and we multiply by the BTC-tsym
        ///     value
        /// </summary>
        /// <param name="tsym">REQUIRED The currency symbol to convert into [Max character length: 10]</param>
        /// <returns></returns>
        Task<HistoricalExchangeVolume> GetHistoricalHourlyExchangeVolume(string tsym);
    }
}