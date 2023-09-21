using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Internal;
using CMS.DocumentEngine.Types.MMK;
using CMS.SiteProvider;
using Kentico.Content.Web.Mvc;
namespace MMK.Models
{
    public class GalleryRepository
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageDataContextRetriever pageDataContextRetriever;


        public GalleryRepository(IPageRetriever pageRetriever, IPageDataContextRetriever pageDataContextRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageDataContextRetriever = pageDataContextRetriever;
        }

        public List<GalleryModel> GetGalleryList()
        {
            var model = new List<GalleryModel>();
            try
            {
                List<Gallery> entity1 = pageRetriever.RetrieveAsync<Gallery>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(GalleryModel.Map(item));
                }
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<GalleryModel> GetTop3GalleryPhoto()
        {
            var model = new List<GalleryModel>();
            try
            {
                List<Gallery> entity1 = pageRetriever.RetrieveAsync<Gallery>(
                               query => query.Published(true)
                               .OnSite(SiteContext.CurrentSiteName).TopN(3)
                               .FirstOrDefault())?.Result.ToList();
                foreach (var item in entity1)
                {
                    model.Add(GalleryModel.Top3(item));
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
