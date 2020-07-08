using Newtonsoft.Json;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class Tag
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public long Name { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }
}
