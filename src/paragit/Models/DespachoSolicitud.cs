using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace paragit.Models
{
    public class DespachoSolicitud
    {
        [Key]
        public string id_despacho { get; set; }
        public DateTime fecha_despacho { get; set; }
        public virtual CatModoInformacion Modoinfo { get; set; }
        public virtual Empleado empleado { get; set; }
        public virtual Archivo archivo { get; set; }
        public virtual Solicitudes despachosolicitud { get; set; }
    }
}
