using Newtonsoft.Json;
using System.Numerics;

namespace Tarkov.Entities
{
    public class ItemPrice
    {
        [JsonProperty("vendor")]
        public Vendor Vendor { get; private set; }

        [JsonProperty("price")]
        public int Price { get; private set; }

        [JsonProperty("currency")]
        public string Currency { get; private set; }

        [JsonProperty("currencyItem")]
        public Item CurrencyItem { get; private set; }

        [JsonProperty("priceRUB")]
        public int PriceRUB { get; private set; }
    }
}
