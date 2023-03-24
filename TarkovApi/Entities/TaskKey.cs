using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TaskKey
    {
        [JsonProperty("keys")]
        public Item[]? Keys { get; private set; }

        [JsonProperty("map")]
        public Map? Map { get; private set; }


    }
}
