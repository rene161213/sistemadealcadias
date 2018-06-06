using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paragit.Models
{
    public class Usuario
    {
        [Key]
        public string id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fech_nacimiento { get; set; }
        public string sexo { get; set; }
        public string clave { get; set; }
        public int num_DUI { get; set; }
        public string email { get; set; }
        public virtual Nacionalidad Nacionalidad { get; set; } 
        public virtual Ocupacion Ocupacion { get; set; }
        public virtual NivelAcademico Nivelacademico { get; set; }
        public List <Solicitudes> solicitudes { get; set; }




    }
}
