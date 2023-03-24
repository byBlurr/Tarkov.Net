using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class RequirementItem
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("item")]
        public Item Item { get; private set; }

        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("quantity")]
        public int Quantity { get; private set; }

        [JsonProperty("attributes")]
        public ItemAttribute[] Attributes { get; private set; }
    }
}
