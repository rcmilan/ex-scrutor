using Services.Interfaces;
using Services.Models;

namespace Services.Implementations
{
    internal class TeacherService : ITeacherService
    {
        private readonly IUserService _userService;

        public TeacherService(IUserService userService)
        {
            _userService = userService;
        }

        public Teacher Add(Teacher teacher)
        {
            _userService.Add(teacher);

            return teacher;
        }

        public Teacher Get(int id)
        {
            var x = (Teacher)_userService.Get(id);

            return x;
        }
    }
}
