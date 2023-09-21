using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;

namespace MMK.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:YYYY-MM-DD}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:YYYY-MM-DD}")]
        public DateTime EndDate { get; set; }
        public string Link { get; set; }

        public string Sdate { get; set; }
        public string Edate { get; set; }
        public string Image { get; set; }
        public string allDays { get; set; }

        public List<EventModel> UpcommingList { get; set; }

        public static EventModel ShowAllEvents(Event _event)
        {
            EventModel events = new EventModel();
            events.Id = _event.EventID;
            events.Title = _event.EventTitle;
            events.Description = _event.EventDetails;
            events.StartDate = _event.StartDate;
            events.EndDate = _event.EndDate;
            events.Link = _event.Link;
            events.Image = _event.Image;
            events.allDays = _event.Days;
            return events;
        }

       
    }
}
