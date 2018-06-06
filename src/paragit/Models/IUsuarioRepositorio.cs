using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> Ocupacion { get; }
        IEnumerable<Usuario> NivelAcademico { get; }

        Usuario ObtenerUsuarioPorCodigo(string CodigoUsu);

    }
}
