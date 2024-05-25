using Integrador.Dal.Data.DataSeed;
using Integrador.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Dal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)

        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CamionSeed());
            modelBuilder.ApplyConfiguration(new ViajeSeed());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<decimal>().HavePrecision(18, 6);
        }
        //Nombre de las  tablas
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Viaje> Viajes { get; set; }
        public virtual DbSet<Camion> Camiones { get; set; }
    }
}
