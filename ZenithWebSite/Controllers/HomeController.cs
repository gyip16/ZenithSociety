using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ZenithDataLib;
using System.Threading.Tasks;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            DateTime today = DateTime.Now;
            int currentDayOfWeek = (int)today.DayOfWeek;
            // If we started on Sunday, we should actually have gone *back*
            // 6 days instead of forward 1...
            if (currentDayOfWeek == 0)
            {
                currentDayOfWeek = -6;
            } else
            {
                currentDayOfWeek = (currentDayOfWeek * -1) + 1;
            }

            DateTime monday = today.AddDays(currentDayOfWeek);
            DateTime sunday = monday.AddDays(6);


            var events = db.Events.Include(e => e.ActivityCategory)
                .Where(e => e.EventToDateAndTime <= sunday &&
                e.EventToDateAndTime >= monday && e.IsActive)
                .OrderBy(e => e.EventToDateAndTime);
            // .ToDictionary (e => e.Key.Date, e => e.ToList());


            Dictionary<DateTime, IEnumerable<Event>> dict = new Dictionary<DateTime, IEnumerable<Event>>();

            foreach (var i in events)
            {
                if (!dict.ContainsKey(i.EventFromDateAndTime.Date))
                    dict.Add(i.EventFromDateAndTime.Date, events.Where(e => e.EventFromDateAndTime.Day == i.EventFromDateAndTime.Day 
                    && e.EventFromDateAndTime.Month == i.EventFromDateAndTime.Month 
                    && e.EventFromDateAndTime.Year == i.EventFromDateAndTime.Year));
            }

            ViewBag.events = dict;

            ViewBag.Message = "For the week of " + monday.ToString() + " to " + sunday.ToString();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}