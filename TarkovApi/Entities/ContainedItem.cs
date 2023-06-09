﻿
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class ContainedItem
    {
        [JsonProperty("item")]
        public Item Item { get; private set; }

        [JsonProperty("count")]
        public float Count { get; private set; }

        [JsonProperty("quantity")]
        public float Quantity { get; private set; }

        [JsonProperty("attributes")]
        public ItemAttribute[] Attributes { get; private set; }


    }
}
