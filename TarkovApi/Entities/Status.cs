using Newtonsoft.Json;

namespace Tarkov.Entities
{
    public class ServerStatus
    {
        [JsonProperty("generalStatus")]
        public Status? GeneralStatus { get; private set; }

        [JsonProperty("currentStatuses")]
        public Status[]? CurrentStatuses { get; private set; }

        [JsonProperty("messages")]
        public StatusMessage[]? Messages { get; private set; }

    }

    public class Status
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("status")]
        public int StatusId { get; private set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; private set; }

    }

    public class StatusMessage
    {
        [JsonProperty("content")]
        public string Content { get; private set; }

        [JsonProperty("time")]
        public string Time { get; private set; }

        [JsonProperty("type")]
        public int StatusId { get; private set; }

        [JsonProperty("solveTime")]
        public string SolveTime { get; private set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; private set; }

    }
}
