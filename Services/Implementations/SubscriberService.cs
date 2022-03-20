using Services.Interfaces;
using Services.Models;
using Services.Repositories;

namespace Services.Implementations
{
    internal class SubscriberService : ISubscriberService
    {
        private readonly IRepository<Subscriber> _repository;

        public SubscriberService(IRepository<Subscriber> repository)
        {
            _repository = repository;
        }

        public Subscriber Add(Subscriber subscriber)
        {
            var result = _repository.Add(subscriber);

            return result;
        }
    }
}
