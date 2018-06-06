using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class NivelAcademico
    {
        [Key]
        public int id_nivel_academico { get; set; }
        public string nivel_academico { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
