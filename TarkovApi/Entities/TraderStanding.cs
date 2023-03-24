using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TraderStanding
    {
        [JsonProperty("trader")]
        public Trader Trader { get; private set; }

        [JsonProperty("standing")]
        public float Standing { get; private set; }
    }
}
