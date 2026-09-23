using System.Collections.Generic;
using System.Web.Mvc;
using POOI_T1_Cruz.Models;

namespace POOI_T1_Cruz.Controllers
{
    public class EmpleadoController : Controller
    {
        public static List<Empleado> Planilla = new List<Empleado>();

        [HttpGet]
        public ActionResult RegistrarEmpleado()
        {
            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado empleado)
        {
            ViewBag.SueldoBasico = empleado.SueldoBasico();
            ViewBag.Escolaridad = empleado.Escolaridad();
            ViewBag.Bonificacion = empleado.Bonificacion();
            ViewBag.MontoAPagar = empleado.MontoAPagar();

            return View(empleado);
        }

        [HttpGet]
        public ActionResult RegistrarAdministrativo()
        {
            return View(new Administrativo());
        }

        [HttpPost]
        public ActionResult RegistrarAdministrativo(Administrativo administrativo)
        {
            ViewBag.SueldoBasico = administrativo.SueldoBasico();
            ViewBag.Escolaridad = administrativo.Escolaridad();
            ViewBag.Bonificacion = administrativo.Bonificacion();
            ViewBag.Incentivo = administrativo.Incentivo();
            ViewBag.MontoAPagar = administrativo.MontoAPagar();

            return View(administrativo);
        }

        [HttpGet]
        public ActionResult Planilla()
        {
            if (Planilla.Count == 0)
            {
                Planilla.Add(new Empleado
                {
                    idEmpleado = "E001",
                    nomapeEmpleado = "Juan Perez",
                    categoriaEmpleado = "E1",
                    nHijos = 2,
                    tipoContrato = "Indefinido"
                });

                Planilla.Add(new Empleado
                {
                    idEmpleado = "E002",
                    nomapeEmpleado = "Maria Lopez",
                    categoriaEmpleado = "E2",
                    nHijos = 1,
                    tipoContrato = "Contratado"
                });

                Planilla.Add(new Empleado
                {
                    idEmpleado = "E003",
                    nomapeEmpleado = "Carlos Ramirez",
                    categoriaEmpleado = "E3",
                    nHijos = 3,
                    tipoContrato = "Indefinido"
                });

                Planilla.Add(new Empleado
                {
                    idEmpleado = "E004",
                    nomapeEmpleado = "Ana Torres",
                    categoriaEmpleado = "E4",
                    nHijos = 0,
                    tipoContrato = "Contratado"
                });
            }

            return View(Planilla);
        }
    }
}
