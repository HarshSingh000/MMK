using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Internal;
using CMS.DocumentEngine.Types.MMK;
using CMS.SiteProvider;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;
using Kentico.Content.Web.Mvc;
namespace MMK.Models
{
    public class ContactRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public ContactRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<ContactModel> GetContactDetasils()
        {
            var model = new List<ContactModel>();
            try
            {
                List<ContactDeails> entity1 = pageRetriever.RetrieveAsync<ContactDeails>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName)
                               .FirstOrDefault())?.Result.ToList();

                foreach (var item in entity1)
                {
                    model.Add(ContactModel.Map(item));
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ContactModel> GetAllMember()
        {
            var model = new List<ContactModel>();
            return model;
        }
    }
}
