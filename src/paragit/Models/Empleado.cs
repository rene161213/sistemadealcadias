using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace paragit.Models
{
    public class Empleado
    {
        [Key]
        public string id_empleado { get; set; }
        public string nom_empleado { get; set; }
        public string ape_empleado { get; set; }
        public DateTime fnac_empleado { get; set; }
        public string sexo { get; set; }
        public virtual Estado estado {get; set;}
        public virtual Nacionalidad nacionalidad { get; set; }
        public virtual Categoria Categoria { get; set; }
        public List<Archivo> CodEmpleado { get; set; }
        public List<DespachoSolicitud> DespachoSolicitud { get; set; }
        
    }
}
