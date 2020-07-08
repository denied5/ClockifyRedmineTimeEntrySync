using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class Task
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("assigneeId")]
        public string AssigneeId { get; set; }

        [JsonProperty("assigneeIds")]
        public object[] AssigneeIds { get; set; }

        [JsonProperty("estimate")]
        public string Estimate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

}
