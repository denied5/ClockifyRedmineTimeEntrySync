using Newtonsoft.Json;
using Services.Clockify.Entity;
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

        public static async Task<List<Tag>> GetTags()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", "Xu9l/AIY629W+XPr");
                var usersResponse = await client.GetAsync($"https://api.clockify.me/api/v1/workspaces/{WorkspaceId}/tags");
                var tags = JsonConvert.DeserializeObject<List<Tag>>(await usersResponse.Content.ReadAsStringAsync());
                return tags;
            }
        }

        public static async Task<List<User>> GetUseres()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", "Xu9l/AIY629W+XPr");
                var usersResponse = await client.GetAsync($"https://api.clockify.me/api/v1/workspaces/{WorkspaceId}/users");
                var users = JsonConvert.DeserializeObject<List<User>>( await usersResponse.Content.ReadAsStringAsync());
                return users;
            }
        }
    }
}
