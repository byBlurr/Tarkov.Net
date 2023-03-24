
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class BossEscort
    {
        [JsonProperty("boss")]
        public MobInfo Boss { get; private set; }

        [JsonProperty("amount")]
        public BossEscortAmount[] Amount { get; private set; }
    }
}
