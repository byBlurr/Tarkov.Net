using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class MobInfo
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("health")]
        public HealthPart[] Health { get; private set; }

        [JsonProperty("imagePortraitLink")]
        public string ImagePortraitLink { get; private set; }

        [JsonProperty("imagePosterLink")]
        public string ImagePosterLink { get; private set; }

        [JsonProperty("equipment")]
        public ContainedItem[] Equipment { get; private set; }

        [JsonProperty("items")]
        public Item[] Items { get; private set; }
    }
}
