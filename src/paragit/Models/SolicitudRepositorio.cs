using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class SolicitudRepositorio: ISolicitudRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public SolicitudRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Solicitudes> ModoInfo
        {
            get
            {
                return _appDbContext.Solicitudes.Include(c =>c.Modoinfo);
            }
        }

        public IEnumerable<Solicitudes> ModoNoti
        {
            get
            {
                return _appDbContext.Solicitudes.Include(c =>c.ModoNoti);
            }
        }

        public Solicitudes GetSolicitudPorCodigo(string CodSolicitu)
        {
            return _appDbContext.Solicitudes.FirstOrDefault(p =>p.id_solicitud == CodSolicitu);
        }
        public Solicitudes GetSolicitudPorUsuario(string codUsuario)
        {
            return _appDbContext.Solicitudes.FirstOrDefault(p => p.Usuario.id_usuario == codUsuario);
        }
    }
}
