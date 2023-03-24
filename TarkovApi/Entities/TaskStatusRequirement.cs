
using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TaskStatusRequirement
    {
        [JsonProperty("task")]
        public Task Task { get; private set; }

        [JsonProperty("status")]
        public String[] Status { get; private set; }
    }
}
