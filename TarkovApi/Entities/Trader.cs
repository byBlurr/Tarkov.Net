using Newtonsoft.Json;
using System.Threading;

namespace Tarkov.Entities
{
    public class Trader
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("resetTime")]
        public string ResetTime { get; private set; }

        [JsonProperty("currency")]
        public Item? Currency { get; private set; }

        [JsonProperty("discount")]
        public float Discount { get; private set; }

        [JsonProperty("levels")]
        public TraderLevel[]? Levels { get; private set; }

        [JsonProperty("barters")]
        public Barter[]? Barters { get; private set; }

        [JsonProperty("cashOffers")]
        public TraderCashOffer[]? CashOffers { get; private set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; private set; }

        [JsonProperty("image4xLink")]
        public string Image4xLink { get; private set; }

        [JsonProperty("tarkovDataId")]
        public int TarkovDataId { get; private set; }
    }
}
