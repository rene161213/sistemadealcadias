using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface IOcupacionRepositorio
    {
        IEnumerable<Ocupacion> PorOcupacion { get; }
    }
}
