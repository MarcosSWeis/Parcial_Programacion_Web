using Ejercicio11.Helper;
using Ejercicio11.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio11.DataAccess
{
    public class VehiculosContext :DbContext
    {
        public VehiculosContext(DbContextOptions<VehiculosContext> options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Rueda> Ruedas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rueda>().HasData(ListRuedas.Listar());
            modelBuilder.Entity<Vehiculo>().HasData(ListVehiculos.ListarVehiculos());

            base.OnModelCreating(modelBuilder);
        }
    }
}
