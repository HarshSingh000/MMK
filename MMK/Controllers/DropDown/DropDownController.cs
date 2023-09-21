using CMS.DocumentEngine.Types.MMK;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using MMK.Controllers;
using MMK.Controllers.DropDown;
using MMK.Models;

[assembly: RegisterPageRoute(Dropdown.CLASS_NAME, typeof(DropDownController), ActionName = "Index", Path = "/Dropdown-Page")]
namespace MMK.Controllers.DropDown
{
    public class DropDownController : Controller
    {
        private readonly IPageDataContextRetriever _dataRetriever;
        private readonly DropDownRepository galleryRepository;

        public DropDownController(IPageDataContextRetriever dataRetriever, DropDownRepository galleryRepository)
        {
            this._dataRetriever = dataRetriever;
            this.galleryRepository = galleryRepository;
        }
        public IActionResult Index()
        {
            var model = galleryRepository.GetContactDetasils();
            return View(model);
        }
    }
}
