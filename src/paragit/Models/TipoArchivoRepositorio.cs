using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class TipoArchivoRepositorio: ITipoArchivoRepositorio
    {
        private readonly AppDbContext _appDbcontext;

        public TipoArchivoRepositorio(AppDbContext appdbcontext)
        {
            _appDbcontext = appdbcontext;
        }

        public IEnumerable<TipoArchivo> TipoArchivo => _appDbcontext.TipoArchivo;
    }
}
