using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface IEmpleadoRepositorio
    {
        IEnumerable<Empleado> Empleado { get; }
        IEnumerable<Empleado> PorCategoria { get; }
        IEnumerable<Empleado> PorEstado { get; }
        Empleado EmpleadoPorCodigo(string CodEmpleado);

    }
}
