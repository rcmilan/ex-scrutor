using Services.Models;

namespace Services.Interfaces
{
    public interface IUserService
    {
        User Get(int id);

        User Add(User user);
    }
}
