using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Service;
using Morango.Application.Security.Interfaces;
using Morango.Application.Security.Services;
using Morango.Application.Shared.Behavior;
using System.Reflection;

namespace Morango.Application.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddTransient<IService, EmailService>();
            services.AddScoped<IPropriedadeService, PropriedadeService>();
            services.AddScoped<IAgricultorService, AgricultorService>();

        }
    }
}