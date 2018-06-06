using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Solicitudes
    {
        [Key]
        public string id_solicitud { get; set; }
        public DateTime fecha_solicitud { get; set; }
        public string info_solicitada { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual CatModoInformacion Modoinfo { get; set; }
        public virtual CatModoNotificacion ModoNoti { get; set; }
        public List<DespachoSolicitud> despachosolicitud { get; set; }

    }
}
