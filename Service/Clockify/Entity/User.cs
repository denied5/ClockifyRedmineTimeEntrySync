using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Clockify.Entity
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("memberships")]
        //public Membership[] Memberships { get; set; }

        [JsonProperty("profilePicture")]
        public Uri ProfilePicture { get; set; }

        //[JsonProperty("activeWorkspace")]
        //public Workspace ActiveWorkspace { get; set; }

        //[JsonProperty("defaultWorkspace")]
        //public Workspace DefaultWorkspace { get; set; }

        //[JsonProperty("settings")]
        //public Settings Settings { get; set; }

        //[JsonProperty("status")]
        //public Status Status { get; set; }
    }
}
