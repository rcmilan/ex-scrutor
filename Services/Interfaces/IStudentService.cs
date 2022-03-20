using Services.Models;

namespace Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> Get();
    }
}
