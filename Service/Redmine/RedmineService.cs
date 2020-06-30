using Services.Entity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public static class RedmineService
    {
        public static async Task<TimeEntryActivities> GetActivities()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Redmine-API-Key", "199aa0d8cfc78b5e668f487ca02c4c15f8e52f83");
                var response = await client.GetAsync("https://task.powerbooks.xyz/enumerations/time_entry_activities.json");
                var responseString = await response.Content.ReadAsStringAsync();
                var activitys = JsonSerializer.Deserialize<TimeEntryActivities>(responseString);
                return activitys;
            }
        }
    }
}
