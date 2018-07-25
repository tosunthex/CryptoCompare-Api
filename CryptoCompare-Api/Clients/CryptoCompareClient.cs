using System;
using System.Net.Http;

namespace CryptoCompare_Api.Clients
{
    public class CryptoCompareClient : ICryptoCompareClient
    {
        private static readonly Lazy<CryptoCompareClient> Lazy =
            new Lazy<CryptoCompareClient>(() => new CryptoCompareClient());

        private readonly HttpClient _httpClient;
        private bool _isDisposed;


        public CryptoCompareClient(HttpClientHandler httpClientHandler)
        {
            _httpClient = new HttpClient(httpClientHandler, true);
        }

        public CryptoCompareClient() : this(new HttpClientHandler())
        {
        }

        public static CryptoCompareClient Instance => Lazy.Value;

        public INewsClient NewsClient => new NewsClient(_httpClient);
        public IPriceClient PriceClient => new PriceClient(_httpClient);
        public IStreamingClient StreamingClient => new StreamingClient(_httpClient);
        public IToplistClient ToplistClient => new ToplistClient(_httpClient);
        public IHistorocalDataClient HistoricalDataClient => new HistoricalDataClient(_httpClient);
        public IOtherClient OtherClient => new OtherClient(_httpClient);

        public void Dispose()
        {
            Dispose(true);
        }

        internal virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing) _httpClient?.Dispose();
                _isDisposed = true;
            }
        }
    }
}