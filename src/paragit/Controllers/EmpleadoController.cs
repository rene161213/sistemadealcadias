using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paragit.Models;
using paragit.Viewmodels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace paragit.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoRepositorio _Empleadorepositorio;

        public EmpleadoController(IEmpleadoRepositorio Empleadorepositorio)
        {
            _Empleadorepositorio = Empleadorepositorio;
        }
        public ViewResult empleado()
        {
            ListaSolicitudesViewModels Listapersonas = new ListaSolicitudesViewModels();
            Listapersonas.ListaEmpleado = _Empleadorepositorio.PorCategoria;
            return View(Listapersonas);
        }
    }
}
