using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajesUTP.Models;

namespace ViajesUTP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UtpViajesContext db = new UtpViajesContext();
            //db.Buses.Where(a => a.id_bus == 1).ToList();

            return View();
        }


       
        public ActionResult InfoViaje()
        {

            return View();
        }
        public ActionResult AdminViaje() {
            return View();
        }
        public ActionResult ImprimePasaje()
        {
            return View();
        }
        public ActionResult Asientos()
        {
            return View();
        }
        public ActionResult PagBusqueda()
        {

            return View();
        }
        public ActionResult Pagar()
        {

            return View();
        }

        [HttpGet]
        public ActionResult RegistrasDatosUsuario()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrasDatosUsuario(Usuarios u)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (UtpViajesContext db= new UtpViajesContext()) {
                    db.Usuarios.Add(u);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("","Error al registrar usuario--" + ex.Message);
                return View();
            }
      
            
        }




    }
}