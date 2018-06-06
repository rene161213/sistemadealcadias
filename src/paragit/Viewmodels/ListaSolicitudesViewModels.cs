using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using paragit.Models;

namespace paragit.Viewmodels
{
    public class ListaSolicitudesViewModels
    {
        public IEnumerable<Solicitudes> Solicitudes { get; set; }
        public IEnumerable<Empleado> ListaEmpleado { get; set; }
        public IEnumerable<Archivo> Archivo { get; set; }
        public IEnumerable<Usuario> Usuario { get; set; }


    }
}
