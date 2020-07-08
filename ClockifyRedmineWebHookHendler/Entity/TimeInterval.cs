using Newtonsoft.Json;
using System;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class TimeInterval
    {
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        public DateTime End { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }
}
