using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Estado
    {
        [Key]
        public int id_estado { get; set; }
        public string nom_estado { get; set; }
        public List<Empleado>empleado { get; set; }
    }
}
