using System;
using System.Net.Http;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Clients
{
    public class CryptoCompareClient : ICryptoCompareClient, IDisposable
    {
        private static readonly Lazy<CryptoCompareClient> Lazy =
            new Lazy<CryptoCompareClient>(() => new CryptoCompareClient());

        private readonly HttpClient _httpClient;
        private bool _isDisposed;


        public CryptoCompareClient(HttpClientHandler httpClientHandler,string apiKey)
        {
            _httpClient = new HttpClient(httpClientHandler, true);
            if (!string.IsNullOrEmpty(apiKey))
            {
                BaseApiUrls.ApiKey = apiKey;
            }
        }

        public CryptoCompareClient() : this(new HttpClientHandler(),"")
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
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }
            if (disposing)
            {
                _httpClient?.Dispose();
            }
            _isDisposed = true;
        }
    }
}