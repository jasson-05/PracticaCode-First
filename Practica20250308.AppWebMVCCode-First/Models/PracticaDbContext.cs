using Microsoft.EntityFrameworkCore;
namespace Practica20250308.AppWebMVCCode_First.Models
{
    public class PracticaDbContext : DbContext
    {
        public PracticaDbContext(DbContextOptions<PracticaDbContext> options) : base(options) { }
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Alumno> alumno{ get; set; }

    }
}
