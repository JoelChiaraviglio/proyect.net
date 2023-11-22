
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Domain.Interfaces;
using ProyectoFinal.Infraestructure.Database;
using ProyectoFinal.Infraestructure.Repositories;

namespace ProyectoFinal.Infraestructure
{
    public static class Installer
    {
        public static void InstallRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SqlServerContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<ICandidateRepository, CandidateRepository>();
        }
    }
}
