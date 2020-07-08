using RedmineApi.Core;
using RedmineApi.Core.Types;
using Services.Entity;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public static async Task<Dictionary<int, User>> GetUsersDictionary()
        {
            RedmineManager redmineManager = new RedmineManager("https://task.powerbooks.xyz", "199aa0d8cfc78b5e668f487ca02c4c15f8e52f83");
            Dictionary<int, User> users = new Dictionary<int, User>();
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    users[i] = await redmineManager.Get<User>(i.ToString(), new NameValueCollection());
                }
                catch (Exception)
                {
                    users[i] = null;
                }
                
               
            }
            return users;
        }
    }
}
