
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class Barter
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("trader")]
        public Trader Trader { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("taskUnlock")]
        public Task TaskUnlock { get; private set; }

        [JsonProperty("requiredItems")]
        public ContainedItem[] RequiredItems { get; private set; }

        [JsonProperty("rewardItems")]
        public ContainedItem[] RewardItems { get; private set; }
    }
}
