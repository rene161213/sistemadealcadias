using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Nacionalidad
    {
        [Key]
        public int id_nacionalidad { get; set; }
        public string nacionalidad { get; set; }
        public List<Usuario> Usuario { get; set; }
        public List<Empleado> nacion { get; set; }
    }
}
