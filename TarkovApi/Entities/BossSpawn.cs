using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class BossSpawn
    {
        [JsonProperty("boss")]
        public MobInfo Boss { get; private set; }

        [JsonProperty("spawnChance")]
        public float SpawnChance { get; private set; }

        [JsonProperty("spawnLocations")]
        public BossSpawnLocation[] SpawnLocations { get; private set; }

        [JsonProperty("escorts")]
        public BossEscort[] Escorts { get; private set; }

        [JsonProperty("spawnTime")]
        public int SpawnTime { get; private set; }

        [JsonProperty("spawnTimeRandom")]
        public bool SpawnTimeRandom { get; private set; }

        [JsonProperty("spawnTrigger")]
        public string SpawnTrigger { get; private set; }


    }
}
