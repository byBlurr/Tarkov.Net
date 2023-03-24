
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class BossSpawnLocation
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("chance")]
        public float Chance { get; private set; }
    }
}
