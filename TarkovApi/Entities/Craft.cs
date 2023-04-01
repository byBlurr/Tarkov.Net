

using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class Craft
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("station")]
        public HideoutStation Station { get; private set; }

        [JsonProperty("level")]
        public int? Level { get; private set; }

        [JsonProperty("taskUnlock")]
        public Task TaskUnlock { get; private set; }

        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        [JsonProperty("requiredItems")]
        public ContainedItem[] RequiredItems { get; private set; }

        [JsonProperty("requiredQuestItems")]
        public QuestItem[] RequiredQuestItems { get; private set; }

        [JsonProperty("rewardItems")]
        public ContainedItem[] RewardItems { get; private set; }
    }
}
