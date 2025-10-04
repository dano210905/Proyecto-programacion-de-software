using library;
using Microsoft.EntityFrameworkCore;

namespace apiproyect.Data
{
    public class Datacontext: DbContext

    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
        }
  
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Especialista> Especialistas { get; set; }
        public DbSet<PBienestar> PBienestars { get; set; }
        public DbSet<Empleadoactividad> Empleadoactividades { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleadoactividad>()
                .HasKey(ea => new { ea.IdEmpleado, ea.IdActividad });
            modelBuilder.Entity<Empleadoactividad>()
                .HasOne(ea => ea.Empleado)
                .WithMany(e => e.EmpleadoActividades)
                .HasForeignKey(ea => ea.IdEmpleado);
            modelBuilder.Entity<Empleadoactividad>()
                .HasOne(ea => ea.Actividad)
                .WithMany(a => a.EmpleadoActividades)
                .HasForeignKey(ea => ea.IdActividad);
        }




    }
}
