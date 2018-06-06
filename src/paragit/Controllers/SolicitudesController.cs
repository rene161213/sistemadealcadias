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
    public class SolicitudesController : Controller
    {
        private readonly ISolicitudRepositorio _solicitudesrepositorio;
        private readonly ICatModoInformacionRepositorio _modoinfo;

        public SolicitudesController (ISolicitudRepositorio solicitudesrepositorios, ICatModoInformacionRepositorio modoinfo)
        {
            _solicitudesrepositorio = solicitudesrepositorios;
            _modoinfo = modoinfo;
        }
        public ViewResult Solicitudes()
        {
            ListaSolicitudesViewModels Listasolicitudesviewmodel = new ListaSolicitudesViewModels();
            Listasolicitudesviewmodel.Solicitudes = _solicitudesrepositorio.ModoInfo;
            
            return View(Listasolicitudesviewmodel);
        }
    }
}
