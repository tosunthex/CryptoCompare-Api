using System;

namespace CryptoCompare_Api.Clients
{
    public interface ICryptoCompareClient:IDisposable
    {
        INewsClient NewsClient { get; }
    }
}