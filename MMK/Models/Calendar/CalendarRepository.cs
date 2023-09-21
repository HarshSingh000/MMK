using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Internal;
using CMS.DocumentEngine.Types.MMK;
using CMS.SiteProvider;
using CMS.DataEngine;
using Kentico.Content.Web.Mvc;
namespace MMK.Models
{
    public class CalendarRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public CalendarRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<EventModel> AllEvents()
        {
            var model = new List<EventModel>();
            try
            {
                List<Event> entity1 = pageRetriever.RetrieveAsync<Event>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName).OrderByAscending("Startdate").Where("StartDate", QueryOperator.GreaterOrEquals, DateTime.Today)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(EventModel.ShowAllEvents(item));
                }
                
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<EventModel> UPEvents()
        {

            var events = pageRetriever.RetrieveAsync<Event>(
            query => query.Published()
            .OnSite(SiteContext.CurrentSiteName)
            .Where("StartDate", QueryOperator.GreaterOrEquals, DateTime.Today)
            .OrderByAscending("Startdate")
            .ToList()
            )?.Result.Select(e => EventModel.ShowAllEvents(e));
            var groupedEvents = events.GroupBy(e => e.StartDate.Date).ToList();
            var upcomingEvents = groupedEvents.FirstOrDefault()?.ToList();
            return upcomingEvents;

        }
    }
}
