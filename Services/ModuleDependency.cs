using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using Services.Interfaces;

namespace Services
{
    public static class ModuleDependency
    {
        public static void AddServicesModule(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblyOf<IUserService>()
                    .AddClasses(c => c.InNamespaces("Services.Implementations"))
                        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                        .AsImplementedInterfaces()
                        .WithScopedLifetime()
                );
        }
    }
}