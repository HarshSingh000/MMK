using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Internal;
using CMS.DocumentEngine.Types.MMK;
using CMS.SiteProvider;
using DocumentFormat.OpenXml.Office.CustomUI;
using Kentico.Content.Web.Mvc;
namespace MMK.Models
{
    public class TeamRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public TeamRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<TeamModel> GetMemberList()
        {
            var model = new List<TeamModel>();
            try
            {
                List<Team> entity1 = pageRetriever.RetrieveAsync<Team>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(TeamModel.Map(item));
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
