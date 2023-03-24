using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TaskObjective
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("maps")]
        public Map[] Maps { get; private set; }

        [JsonProperty("optional")]
        public bool Optional { get; private set; }
    }
}
