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
    public class FaqRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public FaqRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<FaqModel> GetFaqList()
        {
            var model = new List<FaqModel>();
            try
            {
                List<Faq> entity1 = pageRetriever.RetrieveAsync<Faq>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(FaqModel.Map(item));
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
