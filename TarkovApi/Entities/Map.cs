using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class Map
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("tarkovDataId")]
        public string TarkovDataId { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalizedName")]
        public string NormalizedName { get; private set; }

        [JsonProperty("wiki")]
        public string Wiki { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("enemies")]
        public String[] Enemies { get; private set; }

        [JsonProperty("raidDuration")]
        public int RaidDuration { get; private set; }

        [JsonProperty("players")]
        public string Players { get; private set; }

        [JsonProperty("bosses")]
        public BossSpawn[] Bosses { get; private set; }

        [JsonProperty("nameId")]
        public string NameId { get; private set; }
    }
}
