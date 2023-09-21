using CMS.DocumentEngine.Types.MMK;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using MMK.Controllers;
using MMK.Models;
using System.Reflection.Metadata;

[assembly: RegisterPageRoute(GalleryPage.CLASS_NAME, typeof(GalleryController), ActionName = "Index", Path = "/Gallery-Page")]


namespace MMK.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IPageDataContextRetriever _dataRetriever;
        private readonly GalleryRepository galleryRepository;

        public GalleryController(IPageDataContextRetriever dataRetriever, GalleryRepository galleryRepository)
        {
            this._dataRetriever = dataRetriever;
            this.galleryRepository = galleryRepository;
        }
        public IActionResult Index()
        {
            var model = galleryRepository.GetGalleryList();
            return View(model);
        }
    }
}
