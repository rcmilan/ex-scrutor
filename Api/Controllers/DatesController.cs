using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        [HttpGet("now")]
        public DateTime GetNow([FromServices] IDateService dateService)
        {
            return dateService.Now();
        }
    }
}
