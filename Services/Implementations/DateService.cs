using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;

namespace Services.Implementations
{
    internal class DateService : IDateService
    {
        private readonly IServiceProvider _serviceProvider;

        public DateService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public DateTime Now()
        {
            var studentService = _serviceProvider.GetService<IStudentService>();

            ArgumentNullException.ThrowIfNull(studentService);

            var students = studentService.Get();

            return DateTime.Now.AddDays(students.Count());
        }
    }
}