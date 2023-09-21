using AngleSharp.Dom.Events;
using CMS.DocumentEngine.Types.MMK;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.EMMA;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using MMK.Controllers;
using MMK.Models;
using System.Text.Json;
using System;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;

[assembly: RegisterPageRoute(Calendar.CLASS_NAME, typeof(CalendarController), ActionName = "Index", Path = "/CalendarPage")]
namespace MMK.Controllers
{
    public class CalendarController : Controller
    {
        //public IActionResult Index()
        //{
        //    ViewData["events"] = new[]
        //    {
        //        new CalendarModel { Id = 1, Title = "Video for Marisa", StartDate = "2023-03-30", EndDate="2023-03-31", Description="THis is Description"},
        //        new CalendarModel { Id = 2, Title = "Preparation", StartDate = "2023-04-12", EndDate="2023-04-15", Description="THis is Description"},
        //        new CalendarModel { Id = 2, Title = "Preparation", StartDate = "2023-04-20", EndDate="2023-07-15", Description="THis is Description"},
        //    };
        //    return View();
        //}


        private readonly IPageDataContextRetriever _dataRetriever;
        private readonly CalendarRepository calendarRepository;

        public CalendarController(IPageDataContextRetriever dataRetriever, CalendarRepository calendarRepository)
        {
            this._dataRetriever = dataRetriever;
            this.calendarRepository = calendarRepository;
        }
        public IActionResult Index()
        {
            var model = calendarRepository.AllEvents();
            foreach (var menuname in model)
            {
                menuname.Sdate = menuname.StartDate.ToString("yyyy-MM-dd");
                menuname.Edate = menuname.EndDate.ToString("yyyy-MM-dd");

                if (menuname.Sdate.ToString() != menuname.EndDate.ToString())
                {
                    menuname.Sdate = menuname.StartDate.ToString("yyyy-MM-dd");
                    menuname.Edate = menuname.EndDate.AddDays(1).ToString("yyyy-MM-dd");
                }
                
                
                menuname.allDays = "[" + menuname.allDays.ToString().Replace("|", ",") + "]";
                
            }
            ViewData["events"] = model;

            //ViewData["events"] = "[{title: 'All Day Event',description: 'description for All Day Event',start: '2023-03-01'}]";

            //var opt = new JsonSerializerOptions() { WriteIndented = true };
            //string strJson = JsonSerializer.Serialize<EventModel>(model, opt);
            //var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var upcomingEvent = calendarRepository.UPEvents().ToList();

            ViewData["upcomingEvent"] = upcomingEvent;
            return View(model);
        }

        public JsonResult GetEvent()
        {
            var model = calendarRepository.AllEvents();
            foreach (var menuname in model)
            {
                menuname.Sdate = menuname.StartDate.ToString("yyyy-MM-dd");
                menuname.Edate = menuname.EndDate.ToString("yyyy-MM-dd");
                menuname.allDays = "["+menuname.allDays.ToString().Replace("|", ",")+"]";
            }
            ViewData["events"] = model;
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            return Json(jsonString);
        }
    }
}
