
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TaskStatusRequirement
    {
        [JsonProperty("task")]
        public Quest? Task { get; private set; }

        [JsonProperty("status")]
        public string[] Status { get; private set; }
    }
}
