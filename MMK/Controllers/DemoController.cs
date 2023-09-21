using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Dac.Model;

namespace MMK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        [Route("GetString")]
        public ActionResult GetString()
        {
            return Ok("Test");
        }
    }
}
