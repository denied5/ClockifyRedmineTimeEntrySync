using Services.SpareEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Entity
{

    public class TimeEntryActivities
    {
        public List<Activity> time_entry_activities { get; set; }
    }

    public class Activity: SpareActivity
    {
        public int id { get; set; }
        public bool is_default { get; set; }
    }
}
