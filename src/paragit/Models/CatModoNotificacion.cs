using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class CatModoNotificacion
    {
        [Key]
        public int id_modo_noti { get; set; }
        public string modo_noti { get; set; }
        public List<Solicitudes> Solicitud { get; set; }
    }
}
