using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class RequirementSkill
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }
    }
}
