using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var user = _userService.Get(id);

            return Ok(user);
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            var result = _userService.Add(user);

            return Ok(result);
        }
    }
}
