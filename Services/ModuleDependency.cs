using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace Services
{
    public static class ModuleDependency
    {
        public static void AddServicesModule(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromCallingAssembly()
                    // Scoped Services
                    .AddClasses(c => c.InNamespaces("Services.Implementations"))
                        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                        .AsImplementedInterfaces()
                        .WithScopedLifetime()

                    // Singleton Repositories
                    .AddClasses(c => c.InNamespaces("Services.Repositories"))
                        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                        .AsImplementedInterfaces()
                        .WithSingletonLifetime()
                );
        }
    }
}