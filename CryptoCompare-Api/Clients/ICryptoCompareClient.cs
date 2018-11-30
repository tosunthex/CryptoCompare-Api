namespace CryptoCompare_Api.Clients
{
    public interface ICryptoCompareClient
    {
        INewsClient NewsClient { get; }

        IPriceClient PriceClient { get; }

        IStreamingClient StreamingClient { get; }

        IToplistClient ToplistClient { get; }

        IHistorocalDataClient HistoricalDataClient { get; }

        IOtherClient OtherClient { get; }
    }
}