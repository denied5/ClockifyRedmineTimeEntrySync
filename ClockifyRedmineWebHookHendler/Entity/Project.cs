using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class Project
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("estimate")]
        public Estimate Estimate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }
    }

}
