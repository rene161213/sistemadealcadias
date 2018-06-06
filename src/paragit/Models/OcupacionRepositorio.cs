using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class OcupacionRepositorio: IOcupacionRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public OcupacionRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Ocupacion> PorOcupacion => _appDbContext.Ocupacion;
    }
}
