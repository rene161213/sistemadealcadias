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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _UsuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio UsuarioRepositorio)
        {
            _UsuarioRepositorio = UsuarioRepositorio;
        }
        public ViewResult Usuario()
        {
            UsuarioViewModels ListaUsuario = new UsuarioViewModels();
            ListaUsuario.Usuario = _UsuarioRepositorio.Ocupacion;
            return View(ListaUsuario);



        }
    }
}
