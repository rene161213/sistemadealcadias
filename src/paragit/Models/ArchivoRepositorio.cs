using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class ArchivoRepositorio: IArchivoRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ArchivoRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        

        IEnumerable<Archivo> IArchivoRepositorio.ArchivoPorTipo
        {
            get
            {
                return _appDbContext.Archivo.Include(c => c.TipoArchivo);
                
            }
        }

        Archivo IArchivoRepositorio.GetArchivoPorcodigo(string CodArchivo)
        {
            return _appDbContext.Archivo.FirstOrDefault(p => p.id_archivos == CodArchivo);
        }

        Archivo IArchivoRepositorio.GetArchivoPorEmpleado(string Codempleado)
        {
            return _appDbContext.Archivo.FirstOrDefault(E => E.Empleado.id_empleado == Codempleado);
        }
    }
}
