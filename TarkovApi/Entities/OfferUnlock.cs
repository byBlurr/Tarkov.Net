
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class OfferUnlock
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("trader")]
        public Trader Trader { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("item")]
        public Item Item { get; private set; }
    }
}
