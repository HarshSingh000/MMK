using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Internal;
using CMS.DocumentEngine.Types.MMK;
using CMS.SiteProvider;
using DocumentFormat.OpenXml.Office.CustomUI;
using Kentico.Content.Web.Mvc;
namespace MMK.Models
{
    public class MenuRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        

        public MenuRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<NameMenu> GetMenuList()
        {
            var model = new List<NameMenu>();
            try
            {
                List<MenuNav> entity1 = pageRetriever.RetrieveAsync<MenuNav>(
                query => query.Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                //.Columns(cols)
                .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(NameMenu.Map(item));
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
