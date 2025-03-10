using Esthiber_Valentin_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Esthiber_Valentin_P2_AP1.DAL
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        DbSet<Ciudades> Ciudades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudades>()
                .HasData(
                    new List<Ciudades>()
                    {
                        new(){CiudadesId = 1,Nombre="Puerto Plata",            Monto=0},
                        new(){CiudadesId = 2,Nombre="San Francisco de Macoris",Monto=0},
                        new(){CiudadesId = 3,Nombre="Cotui",                   Monto=0}
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
