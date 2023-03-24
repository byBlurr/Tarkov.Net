
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TaskRewards
    {
        [JsonProperty("traderStanding")]
        public TraderStanding[] TraderStanding { get; private set; }

        [JsonProperty("items")]
        public ContainedItem[] Items { get; private set; }

        [JsonProperty("offerUnlock")]
        public OfferUnlock[] OfferUnlock { get; private set; }

        [JsonProperty("skillLevelReward")]
        public SkillLevel[] SkillLevelReward { get; private set; }

        [JsonProperty("traderUnlock")]
        public Trader[] TraderUnlock { get; private set; }

        [JsonProperty("craftUnlock")]
        public Craft[] CraftUnlock { get; private set; }


    }
}
