using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace CryptoCompare_Api.Models.Responses.Other
{
    public class ExchangesListResponse: ReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>>
    {
        public ExchangesListResponse(IDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> dictionary)
            : base(dictionary)
        {
        }
    }
}