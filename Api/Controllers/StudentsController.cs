using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;
using Services.Repositories;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository<Student> _repository;
        private readonly IStudentService _service;

        public StudentsController(IRepository<Student> repository, IStudentService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpPost]
        public ActionResult Post(Student student)
        {
            var result = _repository.Add(student);

            return Ok(result);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var result = _repository.Get(id);

            return Ok(result);
        }

        [HttpGet("all")]
        public ActionResult Get()
        {
            var result = _service.Get();

            return Ok(result);
        }
    }
}
