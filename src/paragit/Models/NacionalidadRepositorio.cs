using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public class NacionalidadRepositorio: INacionalidadRepositorio
    {
        private readonly AppDbContext _appDbContext;
        
        public NacionalidadRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Nacionalidad> Nacionalidad => _appDbContext.Nacionalidad;
    }
}
