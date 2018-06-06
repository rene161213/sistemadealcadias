using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }//fin del constructor.

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<NivelAcademico> NivelAcademico { get; set; }
        public DbSet<Solicitudes> Solicitudes { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<CatModoInformacion> ModoInfo { get; set; }
        public DbSet<CatModoNotificacion> ModoNoti { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Archivo> Archivo { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Nacionalidad> Nacionalidad { get; set; }
        public DbSet<TipoArchivo> TipoArchivo { get; set; }
        public DbSet<Ocupacion> Ocupacion { get; set; }
        public DbSet<DespachoSolicitud> Despacho { get; set; }
    }
}
