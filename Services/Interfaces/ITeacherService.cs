using Services.Models;

namespace Services.Interfaces
{
    public interface ITeacherService
    {
        Teacher Add(Teacher teacher);

        Teacher Get(int id);
    }
}