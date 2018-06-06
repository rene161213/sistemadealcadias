using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       public IEnumerable<Usuario> Ocupacion
        {
            get
            {
                return _appDbContext.Usuario.Include(c => c.Ocupacion);
            }
        }

        public IEnumerable<Usuario> NivelAcademico
        {
            get
            {
                return _appDbContext.Usuario.Include(c => c.Nivelacademico.nivel_academico);
            }
        }

        public Usuario ObtenerUsuarioPorCodigo(string CodigoUsu)
        {
            return _appDbContext.Usuario.FirstOrDefault(p => p.id_usuario == CodigoUsu);
        }
        
    }
}
