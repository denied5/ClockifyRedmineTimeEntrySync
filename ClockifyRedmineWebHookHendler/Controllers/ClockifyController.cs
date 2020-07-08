using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ClocifyResmineWebHookHHendler.Entity;
using ClocifyResmineWebHookHHendler.Helper;
using Microsoft.AspNetCore.Mvc;
using RedmineApi.Core;
using RedmineApi.Core.Types;
using Services;

namespace ClocifyResmineWebHookHHendler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClockifyController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> CreateTimeEntry(TimeEntryClockify timeEntry)
        {
            HttpClient client = new HttpClient();
            var RedmineUserID = Dictionarys.CloclifyToRedmineUserId[timeEntry.UserId];
            var RedmineAPiKey = Dictionarys.RedmineUserIdApi[RedmineUserID];
            client.DefaultRequestHeaders.Add("X-Redmine-API-Key", RedmineAPiKey);


            var timeEntryToSend = new TimeEntryRedmine();
            var timeSpan = timeEntry.TimeInterval.Start - timeEntry.TimeInterval.End;
            timeEntryToSend.hours = timeSpan.TotalHours;
            //name of activity to id
            if (timeEntry.Tags.FirstOrDefault() != null)
            {
                timeEntryToSend.activity_id = Convert.ToInt32(Dictionarys.TimeActivitysClockifyRedmine[timeEntry.Tags.First().Id]);
            }
           
            timeEntryToSend.comments = timeEntry.Description?.Take(250).ToString();
            //issue_id = timeEntry.task.TaskID -> issueId|| ..task.name -> issueId
            timeEntryToSend.issue_id = 142;// Convert.ToInt32(timeEntry.Task.Id);
            timeEntryToSend.spent_on = timeEntry.TimeInterval.Start;

            var s = XmlConverter.XmlConvert(timeEntryToSend);
            
            var data = new StringContent(s, Encoding.UTF8, "application/xml");

            var response = await client.PostAsync("https://task.powerbooks.xyz/time_entries.xml", data);

            return Ok( timeEntry);
        }

        //[HttpGet]
        //public IActionResult UpdateTimeEntry(TimeEntryClockify timeEntry)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult DeleteTimeEntry()
        //{
        //    return View();
        //}
    }
}