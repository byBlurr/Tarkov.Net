﻿
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class SkillLevel
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("level")]
        public float Level { get; private set; }
    }
}
