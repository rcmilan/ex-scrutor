using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;
using Services.Repositories;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController : ControllerBase
    {
        private readonly ISubscriberService _service;
        private readonly IRepository<Subscriber> _repository;
        public SubscribersController(ISubscriberService service, IRepository<Subscriber> repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpPost]
        public ActionResult Post(Subscriber subscriber)
        {
            var result =_service.Add(subscriber);

            return Ok(result);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var result = _repository.Get(id);

            return Ok(result);
        }

    }
}
