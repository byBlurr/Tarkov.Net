﻿
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TraderCashOffer
    {
        [JsonProperty("item")]
        public Item Item { get; private set; }

        [JsonProperty("minTraderLevel")]
        public int MinTraderLevel { get; private set; }

        [JsonProperty("price")]
        public int Price { get; private set; }

        [JsonProperty("currency")]
        public string Currency { get; private set; }

        [JsonProperty("currencyItem")]
        public Item CurrencyItem { get; private set; }

        [JsonProperty("priceRUB")]
        public int PriceRUB { get; private set; }

        [JsonProperty("taskUnlock")]
        public Task TaskUnlock { get; private set; }
    }
}
