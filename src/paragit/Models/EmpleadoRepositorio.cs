using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace paragit.Models
{
    public class EmpleadoRepositorio: IEmpleadoRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public EmpleadoRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IEnumerable<Empleado> Empleado
        {
            get
            {
                return _appDbContext.Empleado;
            }
        }

        public IEnumerable<Empleado> PorCategoria
        {
            get
            {
               return _appDbContext.Empleado.Include(c =>c.Categoria);
            }
        }

        public IEnumerable<Empleado> PorEstado
        {
            get
            {
                return _appDbContext.Empleado.Include(e =>e.estado);
            }
        }

        public Empleado EmpleadoPorCodigo(string CodEmpleado)
        {
            return _appDbContext.Empleado.FirstOrDefault(p =>p.id_empleado == CodEmpleado);
        }
    }
}
