using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Application.Models;
using System.Reflection;

namespace ProyectoFinal.Application
{
    public static class Installer
    {
        public static void InstallApplication(this IServiceCollection services)
        {

            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

        }
    }
}
