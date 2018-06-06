using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface ISolicitudRepositorio
    {
        IEnumerable<Solicitudes> ModoInfo { get; }
        IEnumerable<Solicitudes> ModoNoti { get; }
        Solicitudes GetSolicitudPorCodigo(string CodSolicitu);
        Solicitudes GetSolicitudPorUsuario(string CodUsuario);
    }
}
