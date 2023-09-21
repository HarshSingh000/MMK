using CMS.DocumentEngine.Types.MMK;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.Forms.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MMK.Controllers;
using MMK.Models;
using System.Collections.Generic;

[assembly: RegisterPageRoute(HomePage.CLASS_NAME, typeof(HomeController), ActionName = "Index", Path = "/Home")]
// Registers a form component for use in the form builder

namespace MMK.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever _dataRetriever;
        private readonly ContactRepository contactRepository;
        private readonly GalleryRepository galleryRepository;

        public HomeController(IPageDataContextRetriever dataRetriever, ContactRepository contactRepository, GalleryRepository galleryRepository)
        {
            this._dataRetriever = dataRetriever;
            this.contactRepository = contactRepository;
            this.galleryRepository = galleryRepository;
        }

        public IActionResult Index()
        {
            List<ContactModel> ContactDetails = new List<ContactModel>();
            List<GalleryModel> GalleryList = new List<GalleryModel>();

            ContactDetails = contactRepository.GetContactDetasils();
            GalleryList = galleryRepository.GetTop3GalleryPhoto();

            HomeViewModel objHomeModel = new HomeViewModel();
            objHomeModel.ContactViewModel = ContactDetails;
            objHomeModel.GalleryViewModel = GalleryList;
            return View(objHomeModel);
        }
    }
}
