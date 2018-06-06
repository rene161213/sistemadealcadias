using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class CatModoNotiRepositorio: ICatModoNotificacionRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public CatModoNotiRepositorio (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<CatModoNotificacion> CatModoNoti => _appDbContext.ModoNoti;
    }
}
