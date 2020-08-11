using Capa.Core.VistaModelo;
using Capa.Data.Modelo;
using Capa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicioBecarioV2._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UsuarioVistaModelo user = new UsuarioModelo().ObtenerUsuarios(1);
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            int valor = new UsuarioModelo().agregauser("Juan", "23455");
            return View();
        }

        public ActionResult Contact()
        {
            int i = 3;
            int Zero = 0;
            try
            {
                int resultado = i / Zero;
            }
            catch (DivideByZeroException e)
            {
                //BitacoraEventos.InsertaEvento("L03036903", "Divicion en cero", "Al hacer la divicion", e.Message.ToString());
                // BitacoraEventos.InsertaError("fsd", "sfs", "ada", "sfsfsfd", "L030378");
                BitacoraEventos.InsertaError("SolicitudMateriaController", "BuscarSolicitudes", "buscar solicitud de materia", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), "L03036903");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}