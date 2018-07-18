using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class MultipleSymbolFullDataRaw:Dictionary<string,IDictionary<string,RawCryptoData>>
    {
    }
}