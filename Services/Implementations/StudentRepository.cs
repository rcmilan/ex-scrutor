using Services.Interfaces;
using Services.Models;
using Services.Repositories;

namespace Services.Implementations
{
    internal class StudentRepository : IRepository<Student>, IStudentService
    {
        private readonly IRepository<Student> _repository;

        private readonly static List<Student> _cachedStudents = new();

        public StudentRepository(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public Student Add(Student entity)
        {
            if (_cachedStudents.SingleOrDefault(cs => cs.Id == entity.Id) is Student student && student is not null)
            {
                return student;
            }

            _cachedStudents.Add(entity);
            _repository.Add(entity);

            return entity;
        }

        public Student Get(int id)
        {
            if (_cachedStudents.SingleOrDefault(cs => cs.Id == id) is Student student && student is not null)
            {
                return student;
            }

            return _repository.Get(id);
        }

        public IEnumerable<Student> Get()
        {
            return _cachedStudents;
        }
    }
}
