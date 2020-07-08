using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Entity
{
    public class TimeEntryRedmine
    {
        public int issue_id { get; set; }
        public DateTime spent_on { get; set; }
        public double hours { get; set; }
        public int activity_id { get; set; }
        public string comments { get; set; }
    }
}
