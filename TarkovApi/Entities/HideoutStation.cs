using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class HideoutStation
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("levels")]
        public HideoutStationLevel[] Levels { get; private set; }

        [JsonProperty("tarkovDataId")]
        public int TarkovDataId { get; private set; }

        [JsonProperty("crafts")]
        public Craft[] Crafts { get; private set; }
    }
}
