using Microsoft.AspNetCore.Mvc;
using CVWebApp.Models;
using System.Collections.Generic;
using Web.Models;

namespace CVWebApp.Controllers
{
    public class CVController : Controller
    {
        private static CV mioCV = new CV();

        public IActionResult Index()
        {
            return View(mioCV);
        }

        public IActionResult InserisciInformazioniPersonali()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InserisciInformazioniPersonali(InformazioniPersonali info)
        {
            mioCV.InformazioniPersonali = info;
            return RedirectToAction("Index");
        }

        public IActionResult InserisciStudi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InserisciStudi(Studi studi)
        {
            mioCV.AddStudi(studi);
            return RedirectToAction("Index");
        }

        public IActionResult InserisciEsperienza()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InserisciEsperienza(Esperienza esperienza)
        {
            Impiego impiego = new Impiego();
            impiego.AddEsperienza(esperienza);
            mioCV.AddImpiego(impiego);
            return RedirectToAction("Index");
        }
    }
}
