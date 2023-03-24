using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class RequirementHideoutStationLevel
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("station")]
        public HideoutStation Station { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }
    }
}
