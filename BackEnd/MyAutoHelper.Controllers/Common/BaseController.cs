using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MyAutoHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok();
        }
    }
}