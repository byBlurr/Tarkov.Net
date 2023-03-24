
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TraderLevel
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("requiredPlayerLevel")]
        public int RequiredPlayerLevel { get; private set; }

        [JsonProperty("requiredReputation")]
        public float RequiredReputation { get; private set; }

        [JsonProperty("requiredCommerce")]
        public int RequiredCommerce { get; private set; }

        [JsonProperty("payRate")]
        public float PayRate { get; private set; }

        [JsonProperty("insuranceRate")]
        public float InsuranceRate { get; private set; }

        [JsonProperty("repairCostMultiplier")]
        public float RepairCostMultiplier { get; private set; }

        [JsonProperty("barters")]
        public Barter[] Barters { get; private set; }

        [JsonProperty("cashOffers")]
        public TraderCashOffer[] CashOffers { get; private set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; private set; }

        [JsonProperty("image4xLink")]
        public string Image4xLink { get; private set; }

    }
}
