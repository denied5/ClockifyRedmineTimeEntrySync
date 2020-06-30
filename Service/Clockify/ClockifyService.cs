using Newtonsoft.Json;
using Services.SpareEntitys;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Clockify
{
    public static class ClockifyService
    {
        static string WorkspaceId = "5eef639c90e5d83a26d79b38";
        public static async void AddTags(List<SpareActivity> activities)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", "Xu9l/AIY629W+XPr");
                foreach (var item in activities)
                {
                    var json = JsonConvert.SerializeObject(item);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = (client.PostAsync($"https://api.clockify.me/api/v1/workspaces/{WorkspaceId}/tags", data).Result);
                }
            }
        }
    }
}
