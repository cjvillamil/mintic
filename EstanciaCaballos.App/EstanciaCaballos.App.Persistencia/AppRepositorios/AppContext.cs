using Microsoft.EntityFrameworkCore;
using EstanciaCaballos.App.Dominio;

namespace EstanciaCaballos.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Caballo> Caballos {get; set;}
        public DbSet<DocumentoVisita> DocumentosVisita {get; set;}
        public DbSet<Historia> Historias {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Recomendacion> Recomendaciones {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}

        public DbSet<PersonaPrueba> persona2 {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EstanciaCaballos");
            }
        }

    }
}