using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class RequirementTrader
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("trader")]
        public Trader? Trader { get; private set; }

        [JsonProperty("requirementType")]
        public string RequirementType { get; private set; }

        [JsonProperty("compareMethod")]
        public string CompareMethod { get; private set; }

        [JsonProperty("value")]
        public int Value { get; private set; }


    }
}
