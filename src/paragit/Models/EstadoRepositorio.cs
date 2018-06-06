using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class EstadoRepositorio: IEstadoRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public EstadoRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Estado> EstadoCivil => _appDbContext.Estado;
    }
}
