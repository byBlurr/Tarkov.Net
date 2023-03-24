
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class HideoutStationLevel
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("constructionTime")]
        public int ConstructionTime { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("itemRequirements")]
        public RequirementItem[] ItemRequirements { get; private set; }

        [JsonProperty("stationLevelRequirements")]
        public RequirementHideoutStationLevel[] StationLevelRequirements { get; private set; }

        [JsonProperty("skillRequirements")]
        public RequirementSkill[] SkillRequirements { get; private set; }

        [JsonProperty("traderRequirements")]
        public RequirementTrader[] TraderRequirements { get; private set; }

        [JsonProperty("tarkovDataId")]
        public int TarkovDataId { get; private set; }

        [JsonProperty("crafts")]
        public Craft[] Crafts { get; private set; }
    }
}
