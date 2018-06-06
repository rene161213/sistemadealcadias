using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface IDespachoSolicitudes
    {
        DespachoSolicitud SolicitudPorEmpleado(string CodEmpleado);
        IEnumerable<DespachoSolicitud> SolicitudesPorModoInfo { get; }
        DespachoSolicitud PorFecha(DateTime porfecha);

    }
}
