using Services.Models;

namespace Services.Repositories
{
    internal class ConcreteRepository<T> : IRepository<T> where T : User
    {
        private static readonly List<User> _users = new();

        public T Add(T entity)
        {
            _users.Add(entity);

            return entity;
        }

        public T Get(int id)
        {
            return (T)_users.Single(u => u.Id == id);
        }
    }
}
