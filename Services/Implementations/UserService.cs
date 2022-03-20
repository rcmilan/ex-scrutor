using Services.Interfaces;
using Services.Models;

namespace Services.Implementations
{
    internal class UserService : IUserService
    {
        private static List<User> _users = new();

        public User Get(int id)
        {
            return _users.Single(u => u.Id == id);
        }

        public User Add(User user)
        {
            _users.Add(user);

            return user;
        }
    }
}
