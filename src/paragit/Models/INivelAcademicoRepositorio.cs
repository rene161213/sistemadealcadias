using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface INivelAcademicoRepositorio
    {
        IEnumerable<NivelAcademico> NivelAcademico { get; }
    }
}
