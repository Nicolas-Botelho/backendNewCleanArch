using Morango.Domain.Interfaces;
using Morango.Infrastructure.Context;
using Morango.Infrastructure.Repositories;
using Morango.Domain.Interfaces.Security;
using Morango.Domain.Interfaces.Common;
using Morango.Domain.Interfaces.Entities;
using Morango.Infrastructure.Repositories.Entities;
using Morango.Infrastructure.Security.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Morango.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = Environment.GetEnvironmentVariable("SqlServer");
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString, x => x.MigrationsAssembly("Morango.Infrastructure")), ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IAgricultorRepository, AgricultorRepository>();
            services.AddScoped<IPropriedadeRepository, PropriedadeRepository>();

        }
    }
}
