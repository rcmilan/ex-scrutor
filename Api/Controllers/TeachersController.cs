using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var result = _teacherService.Get(id);

            return Ok(result);
        }

        [HttpPost]
        public ActionResult Post(Teacher teacher)
        {
            var result = _teacherService.Add(teacher);

            return Ok(result);
        }
    }
}
