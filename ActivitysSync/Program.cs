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
            var redmineActivitys = RedmineService.GetActivities().Result;
            var spareActivity = redmineActivitys.time_entry_activities.Cast<SpareActivity>().ToList();
            ClockifyService.AddTags(spareActivity);
            Console.WriteLine("lol");
        }
    }
}
