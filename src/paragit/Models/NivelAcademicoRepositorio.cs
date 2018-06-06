using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paragit.Models
{
    public class NivelAcademicoRepositorio : INivelAcademicoRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public NivelAcademicoRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<NivelAcademico> NivelAcademico => _appDbContext.NivelAcademico;
        
    }
}
