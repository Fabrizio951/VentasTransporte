using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea3_0209.Models;

namespace Tarea3_0209.Controllers
{
    public class VentasTransporteController : Controller
    {
        // GET: VentasTransporte
        public ActionResult ActionTransporte()
        {
            return View(new Transporte());
        }

        [HttpPost]public ActionResult ActionTransporte(Transporte reg) 
        {
            ViewBag.costo = reg.Costo().ToString("#####.#0");
            ViewBag.seguro = reg.Seguro().ToString("#####.#0");
            ViewBag.monto = reg.Monto().ToString("#####.#0");
            ViewBag.IGV = reg.IGV().ToString("#####.#0");
            ViewBag.MontoTotal = reg.MontoTotal().ToString("#####.#0");
            return View(reg);
        }
    }
}