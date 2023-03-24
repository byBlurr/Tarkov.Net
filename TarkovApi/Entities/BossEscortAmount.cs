using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class BossEscortAmount
    {
        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("chance")]
        public float Chance { get; private set; }
    }
}
