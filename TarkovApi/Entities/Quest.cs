using Newtonsoft.Json;
using System.Text;

namespace Tarkov.Entities
{
    public class Quest
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("tarkovDataId")]
        public int? TarkovDataId { get; private set; } = 0;

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("trader")]
        public Trader? Trader { get; private set; }

        [JsonProperty("map")]
        public Map? Map { get; private set; }

        [JsonProperty("experience")]
        public int Experience { get; private set; }

        [JsonProperty("wikiLink")]
        public string WikiLink { get; private set; }

        [JsonProperty("minPlayerLevel")]
        public int MinPlayerLevel { get; private set; }

        [JsonProperty("taskRequirements")]
        public TaskStatusRequirement[]? TaskRequirements { get; private set; }

        [JsonProperty("traderRequirements")]
        public RequirementTrader[]? TraderRequirements { get; private set; }

        [JsonProperty("objectives")]
        public TaskObjective[]? Objectives { get; private set; }

        [JsonProperty("startRewards")]
        public TaskRewards? StartRewards { get; private set; }

        [JsonProperty("finishRewards")]
        public TaskRewards? FinishRewards { get; private set; }

        [JsonProperty("failConditions")]
        public TaskObjective[]? FailConditions { get; private set; }

        [JsonProperty("failureOutcome")]
        public TaskRewards? FailureOutcome { get; private set; }

        [JsonProperty("restartable")]
        public bool Restartable { get; private set; }

        [JsonProperty("factionName")]
        public string FactionName { get; private set; }

        [JsonProperty("neededKeys")]
        public TaskKey[]? NeededKeys { get; private set; }

        [JsonProperty("kappaRequired")]
        public bool KappaRequired { get; private set; }

        [JsonProperty("lightkeeperRequired")]
        public bool LightkeeperRequired { get; private set; }

        [JsonProperty("descriptionMessageId")]
        public string DescriptionMessageId { get; private set; }

        [JsonProperty("startMessageId")]
        public string StartMessageId { get; private set; }

        [JsonProperty("successMessageId")]
        public string SuccessMessageId { get; private set; }

        [JsonProperty("failMessageId")]
        public string FailMessageId { get; private set; }

        public string GetObjectives()
        {
            StringBuilder b = new StringBuilder();
            
            foreach (TaskObjective obj in Objectives)
            {
                b.AppendLine($"{obj.Description}");
            }

            return b.ToString();
        }
    }
}
