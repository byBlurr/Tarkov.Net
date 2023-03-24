

using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class Vendor
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }
    }
}
