using ClocifyResmineWebHookHHendler.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClocifyResmineWebHookHHendler.Helper
{
    public static class XmlConverter
    {
        public static string XmlConvert(TimeEntryRedmine timeEntryRedmine)
        {
            var s = "<?xml version='1.0' encoding='utf-16'?>" +
                "<time_entry xmlns:xsi = 'http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd = 'http://www.w3.org/2001/XMLSchema' >" +
                $"<issue_id>{timeEntryRedmine.issue_id}</issue_id>" +
                $"<spent_on>{timeEntryRedmine.spent_on.ToString("yyyy-MM-dd")}</spent_on>" +
                $"<hours>{timeEntryRedmine.hours}</hours>" +
                $"<activity_id>{timeEntryRedmine.activity_id}</activity_id>" +
                "</time_entry>";
            return s;
        }

    }
}
