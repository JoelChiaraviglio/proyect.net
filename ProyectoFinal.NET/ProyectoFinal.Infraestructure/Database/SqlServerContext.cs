using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entities;
using System.Reflection;

namespace ProyectoFinal.Infraestructure.Database
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
