using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class HealthPart
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("max")]
        public int Max { get; private set; }

        [JsonProperty("bodyPart")]
        public string BodyPart { get; private set; }
    }
}
