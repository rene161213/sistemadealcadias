using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class CatModoInformacionRepositorio: ICatModoInformacionRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public CatModoInformacionRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CatModoInformacion> CatModoInfo => _appDbContext.ModoInfo;
    }
}
