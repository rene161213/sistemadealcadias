using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Archivo
    {
        [Key]
        public string id_archivos { get; set; }
        public DateTime fecha_archivo { get; set; }
        public string n_documento { get; set; }
        public string nom_emitio_doc { get; set; }
        public string procedencia_doc { get; set; }
        public string doc_archivo { get; set; }
        public virtual TipoArchivo TipoArchivo { get; set; }
        public virtual Empleado Empleado { get; set; }
        public List<DespachoSolicitud> archivo { get; set; }
       

    }
}
