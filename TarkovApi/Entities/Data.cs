using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class TarkovResult
    {
        [JsonProperty("data")]
        public Data Data { get; private set; }
    }

    public class Data
    {
        [JsonProperty("tasks")]
        public Quest[]? Tasks { get; private set; }

        [JsonProperty("crafts")]
        public Craft[]? Crafts { get; private set; }

        [JsonProperty("status")]
        public ServerStatus? ServerStatus { get; private set; }
    }
}
