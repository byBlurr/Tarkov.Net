using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class ItemAttribute
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("value")]
        public string Value { get; private set; }
    }
}
