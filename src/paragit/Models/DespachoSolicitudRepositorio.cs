using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class DespachoSolicitudRepositorio: IDespachoSolicitudes
    {
        private readonly AppDbContext _appDbContext;

        public DespachoSolicitudRepositorio (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public DespachoSolicitud SolicitudPorEmpleado(string odEmpleado)
        {
            return _appDbContext.Despacho.FirstOrDefault(p => p.empleado.id_empleado == odEmpleado);
        }
        public IEnumerable<DespachoSolicitud> SolicitudesPorModoInfo
        {
            get
            {
                return _appDbContext.Despacho.Include(c => c.Modoinfo);
            }
        }

        public DespachoSolicitud PorFecha(DateTime porfecha)
        {
            return _appDbContext.Despacho.FirstOrDefault(p => p.fecha_despacho == porfecha);
            
        }
    }
}
