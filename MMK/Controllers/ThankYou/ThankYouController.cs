using Microsoft.AspNetCore.Mvc;

namespace MMK.Controllers
{
    public class ThankYouController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
