using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class TimeEntryClockify
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("projectId")]
        public object ProjectId { get; set; }

        [JsonProperty("timeInterval")]
        public TimeInterval TimeInterval { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("customFieldValues")]
        public object[] CustomFieldValues { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("task")]
        public Task Task { get; set; }
    }
}
