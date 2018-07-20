using System.Collections.Generic;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class MultipleSymbolFullDataRaw:Dictionary<string,IDictionary<string,RawCryptoData>>
    {
    }
}