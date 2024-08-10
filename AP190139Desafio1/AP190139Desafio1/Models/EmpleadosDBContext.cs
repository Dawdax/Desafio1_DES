using Microsoft.EntityFrameworkCore;
using AP190139Desafio1.Models.Seeds;

namespace AP190139Desafio1.Models
{
    public class EmpleadosDBContext : DbContext
    {
        public EmpleadosDBContext(DbContextOptions<EmpleadosDBContext> options)  : base(options)
        { 

        }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpleadoSeed());
        }
    }
}
