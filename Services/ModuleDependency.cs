using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Models;
using Services.Repositories;

namespace Services
{
    public static class ModuleDependency
    {
        public static void AddServicesModule(this IServiceCollection services)
        {
            services
                .Scan(scan => scan
                    .FromCallingAssembly()
                        // Scoped Services
                        .AddClasses(c => c.InNamespaces("Services.Implementations"))
                            .AsImplementedInterfaces()
                            .WithScopedLifetime()

                        // Singleton Repositories
                        .AddClasses(c => c.InNamespaces("Services.Repositories"))
                            .AsImplementedInterfaces()
                            .WithSingletonLifetime());

            services // Decorators
                .AddSingleton<IRepository<Student>, ConcreteRepository<Student>>()
                .Decorate<IRepository<Student>, StudentRepository>();

        }
    }
}