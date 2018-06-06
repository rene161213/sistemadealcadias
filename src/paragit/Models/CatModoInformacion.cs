using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class CatModoInformacion
    {
        [Key]
        public int id_modo_info { get; set; }
        public string modo_info { get; set; }
        public List <Solicitudes> Solicitud { get; set; }
        public List<DespachoSolicitud> Despacho { get; set; }
    }
}
