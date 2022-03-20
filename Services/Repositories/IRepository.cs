using Services.Models;

namespace Services.Repositories
{
    public interface IRepository<T> where T : User
    {
        T Add(T entity);

        T Get(int id);
    }
}