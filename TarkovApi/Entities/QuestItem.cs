using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class QuestItem
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("shortName")]
        public string ShortName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("width")]
        public int Width { get; private set; }

        [JsonProperty("height")]
        public int Height { get; private set; }

        [JsonProperty("iconLink")]
        public string IconLink { get; private set; }

        [JsonProperty("gridImageLink")]
        public string GridImageLink { get; private set; }

        [JsonProperty("baseImageLink")]
        public string BaseImageLink { get; private set; }

        [JsonProperty("inspectImageLink")]
        public string InspectImageLink { get; private set; }

        [JsonProperty("image512pxLink")]
        public string Image512pxLink { get; private set; }

        [JsonProperty("image8xLink")]
        public string Image8xLink { get; private set; }
    }
}
