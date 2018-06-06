using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace paragit.Models
{
    public class Categoria
    {
        [Key]
        public int id_categoria { get; set; }
        public string categoria { get; set; }
        public List<Empleado> Empleado { get; set; }
    }
}
