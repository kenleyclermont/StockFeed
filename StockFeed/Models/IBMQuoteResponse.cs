using Newtonsoft.Json;
namespace StockFeed.Models
{
    public class IBMQuoteResponse
    {
        [JsonProperty("Global Quote")]
        public IBMData GlobalQuote { get; set; }
    }
}
