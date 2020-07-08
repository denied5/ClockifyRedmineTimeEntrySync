using Services;
using Services.Clockify;
using Services.SpareEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivitysSync
{
    class Program
    {
        static void Main(string[] args)
        {
            //var redmineActivitys = RedmineService.GetActivities().Result;
            //var spareActivity = redmineActivitys.time_entry_activities.Cast<SpareActivity>().ToList();
            //ClockifyService.AddTags(spareActivity);

            //var result = RedmineService.GetUsersDictionary().Result;
            //Console.WriteLine("lol");
            //foreach (var item in result)
            //{
            //    if (item.Value != null)
            //    {
            //        Console.WriteLine("{" + $"\"{item.Value.Id}\", \"{item.Value.ApiKey}\"" + "},");
            //    }
            //}

            //var result = ClockifyService.GetUseres().Result;
            //foreach (var item in result)
            //{
            //    Console.WriteLine("{"+$"\"{item.Id}\", \"{item.Name}\"" + "},");
            //}

            var redmineActivitys = RedmineService.GetActivities().Result;
            var clockifyTags = ClockifyService.GetTags().Result;
            foreach (var item in redmineActivitys.time_entry_activities)
            {
                Console.WriteLine("{" + $"\"{clockifyTags.Where(x => x.name == item.name).FirstOrDefault()?.id}\", \"{item.id}\"" + "},");
            }
        }
    }
}
