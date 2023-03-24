using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class HistoricalPricePoint
    {
        [JsonProperty("price")]
        public int Price { get; private set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; private set; }
    }
}
