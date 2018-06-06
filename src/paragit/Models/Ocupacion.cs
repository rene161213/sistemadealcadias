using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Ocupacion
    {
        [Key]
        public int id_ocupacion { get; set; }
        public string ocupacion { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
