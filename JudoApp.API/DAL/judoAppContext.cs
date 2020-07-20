namespace JudoApp.API.DAL
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    public class judoAppDataContext:DbContext
    {
        public judoAppDataContext(DbContextOptions<judoAppDataContext>options):base(options)
        {
        }
        public DbSet<atleta>Atletas{get;set;}
        public DbSet<cargo>Cargos{get;set;}
        public DbSet<ciudad>Ciudades{get;set;}
        public DbSet<Club>Clubes{get;set;}
        public DbSet<comiteEjecutivo>ComiteteEjecutivo{get;set;}
        public DbSet<contacto>Contactos{get;set;}
        public DbSet<Direccion>Direcciones{get;set;}
        public DbSet<estadistica>Estadisticas{get;set;}
        public DbSet<evento>eventos{get;set;}
        public DbSet<historiaClinica>HistoriasClinica{get;set;}
        public DbSet<historiaClinicaTipo>HistoriaClinicaTipos{get;set;}
        public DbSet<historialDeportivo>historialesDeportivo{get;set;}
        public DbSet<Miembro>Miembros{get;set;}
        public DbSet<pais>Paises{get;set;}
        public DbSet<parentesco>Parentescos{get;set;}
        public DbSet<provincia>Provincias{get;set;}
        public DbSet<sector>Sectores{get;set;}
        public DbSet<Telefono>Telefonos{get;set;}
        public DbSet<tipoEvento>TiposEvento{get;set;}
        public DbSet<tipoTelefono>tiposTelefono{get;set;}

    }
}