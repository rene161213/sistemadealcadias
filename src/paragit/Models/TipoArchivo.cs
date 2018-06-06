using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class TipoArchivo
    {
        [Key]
        public int id_tipo_archivo { get; set; }
        public string nom_tipo_archivo { get; set; }
        public List<Archivo> archivos { get; set; }
    }
}
