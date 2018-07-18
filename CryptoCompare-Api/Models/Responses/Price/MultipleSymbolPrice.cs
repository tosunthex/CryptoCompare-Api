using System.Collections.Generic;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class MultipleSymbolPrice:Dictionary<string,IDictionary<string,float>>
    {
    }
}