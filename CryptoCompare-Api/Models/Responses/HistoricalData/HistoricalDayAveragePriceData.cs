using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class HistoricalDayAveragePriceData : ReadOnlyDictionary<string, double>
    {
        public HistoricalDayAveragePriceData(IDictionary<string, double> dictionary) : base(dictionary)
        {
        }
    }
}