using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajesUTP.Models;

namespace ViajesUTP.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Administrador()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View();
        }

        //BUSES
        [HttpGet]
        public ActionResult RegistrarBuses()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarBuses(Buses b)

        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            try
            {
                using (UtpViajesContext db = new UtpViajesContext()) {
                    db.Buses.Add(b);
                    db.SaveChanges();
                    return View("Administrador");

                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al registrar Buses--" + ex.Message);
                return View();
            }

        }
        public ActionResult VerListaBuses()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View(db.Buses.ToList());
        }
        //modificar buses
        public ActionResult ModificaBuses(int cod) {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {

                    Buses bu = db.Buses.Where(b => b.id_bus == cod).FirstOrDefault();
                    return View(bu);

                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ModificaBuses(Buses b)
        {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext()) {
                    Buses bu = db.Buses.Find(b.id_bus);
                    bu.modelo_bus = b.modelo_bus;
                    bu.placa_bus = b.placa_bus;
                    bu.capacidad_bus = b.capacidad_bus;
                    bu.id_empres = b.id_empres;
                    bu.pisos = b.pisos;
                    bu.url = b.url;
                    bu.tipo_servicio = b.tipo_servicio;

                    db.SaveChanges();

                    return RedirectToAction("Administrador");

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        //EMPRESAS
        public ActionResult RegistrarEmpresas()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarEmpresas(Empresas e)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {
                    db.Empresas.Add(e);
                    db.SaveChanges();
                    return RedirectToAction("Administrador");

                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("Error al agregar empresa", ex);
                return View();
            }


        }
        public ActionResult VerListaEmpresas()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View(db.Empresas.ToList());
        }
        //Modificar empresa
        public ActionResult ModificaEmpresa(int cod)
        {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {

                    Empresas em = db.Empresas.Where(e => e.id_empresa == cod).FirstOrDefault();
                    return View(em);

                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ModificaEmpresa(Empresas e)
        {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {
                    Empresas em = db.Empresas.Find(e.id_empresa);
                    em.Empresa = e.Empresa;
                    em.Direccion = e.Direccion;
                    em.Ruc = e.Ruc;
                    em.CantidadBuses = e.CantidadBuses;

                    db.SaveChanges();

                    return RedirectToAction("Administrador");

                }

            }
            catch (Exception)
            {

                throw;
            }


        }
        public ActionResult EliminarEmpresa(int em)
        {

            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {
                    Empresas emp = db.Empresas.Find(em);
                    db.Empresas.Remove(emp);
                    db.SaveChanges();
                    return RedirectToAction("Administrador");

                }


            }
            catch (Exception)
            {

                throw;
            }
        }


        //USUARIO
        public ActionResult VerClientes()
        {
            return View();
        }

        public ActionResult VerListaUsuarios()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View(db.Usuarios.ToList());

        }
        public ActionResult ModificarUsuario(int usu) {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext()) {
                    Usuarios usua = db.Usuarios.Where(u => u.id_usuario == usu).FirstOrDefault();

                    return View(usua);
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ModificarUsuario(Usuarios u) {
            try
            {
                using (UtpViajesContext db = new UtpViajesContext()) {
                    Usuarios ur = db.Usuarios.Find(u.id_usuario);
                    ur.Nombre = u.Nombre;
                    ur.Apellidos = u.Apellidos;
                    ur.Dni = u.Dni;
                    ur.Sexo = u.Sexo;
                    ur.EstadoCivil = u.EstadoCivil;
                    ur.Telefono = u.Telefono;
                    ur.EmailAddress = u.EmailAddress;
                    ur.Nacionalidad = u.Nacionalidad;
                    ur.LugarNacimiento = u.LugarNacimiento;
                    ur.FechaNacimiento = u.FechaNacimiento;
                    ur.Login = u.Login;
                    ur.Contrasena = u.Contrasena;
                    ur.Direccion = u.Direccion;
                    ur.id_ubicacion = u.id_ubicacion;
                    db.SaveChanges();
                    return RedirectToAction("Administrador");


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        //PASAJES
        [HttpGet]
        public ActionResult RegistrarPasajes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarPasajes(Pasajes p)

        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {
                    db.Pasajes.Add(p);
                    db.SaveChanges();
                    return View("Administrador");

                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al registrar pasaje--" + ex.Message);
                return View();
            }

        }
        public ActionResult VerListaPasajes()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View(db.Pasajes.ToList());
        }


        //VIAJES
        [HttpGet]
        public ActionResult RegistrarViajes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarViajes(Viajes v)

        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            try
            {
                using (UtpViajesContext db = new UtpViajesContext())
                {
                    db.Viajes.Add(v);
                    db.SaveChanges();
                    return View("Administrador");

                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al registrar Viajes--" + ex.Message);
                return View();
            }

        }
        public ActionResult VerListaViajes()
        {
            UtpViajesContext db = new UtpViajesContext();

            return View(db.Viajes.ToList());

        }
    }


}