using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class ItemCategory
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("parent")]
        public ItemCategory Parent { get; private set; }

        [JsonProperty("children")]
        public ItemCategory[] Children { get; private set; }
    }
}
