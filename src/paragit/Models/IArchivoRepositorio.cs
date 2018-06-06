using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface IArchivoRepositorio
    {
        IEnumerable<Archivo> ArchivoPorTipo { get; }
        Archivo GetArchivoPorEmpleado(string Codempleado);

        Archivo GetArchivoPorcodigo(string CodArchivo);
    }
}
