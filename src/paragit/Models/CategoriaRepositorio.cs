using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class CategoriaRepositorio: ICategoriaRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public CategoriaRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Categoria> PorCategoria => _appDbContext.Categoria;
    }
}
