using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MyAutoHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : BaseController
    {
        public ReservationController()
        {
        }

        public override IActionResult Get()
        {
            return Ok();
        }
    }
}