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
using Microsoft.SqlServer.Dac.Extensibility;

namespace MMK.Models
{
    public class DropDownRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public DropDownRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<DropDownModel> GetContactDetasils()
        {
            var model = new List<DropDownModel>();
            try
            {
                List<Dropdown> entity1 = pageRetriever.RetrieveAsync<Dropdown>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(DropDownModel.Map(item));
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
