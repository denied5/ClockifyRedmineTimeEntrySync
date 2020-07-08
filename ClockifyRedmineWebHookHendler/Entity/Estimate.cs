using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class Estimate
    {
        [JsonProperty("estimate")]
        public string EstimateEstimate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
