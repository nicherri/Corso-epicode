// Controllers/HomeController.cs
using Esercizio_del_giorno.Models;
using EsercizioCinema.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Esercizio_del_giorno.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new StatisticheViewModel
            {
                BigliettiVendutiNord = Biglietteria.BigliettiVendutiNord,
                BigliettiRidottiNord = Biglietteria.BigliettiRidottiNord,
                BigliettiVendutiEst = Biglietteria.BigliettiVendutiEst,
                BigliettiRidottiEst = Biglietteria.BigliettiRidottiEst,
                BigliettiVendutiSud = Biglietteria.BigliettiVendutiSud,
                BigliettiRidottiSud = Biglietteria.BigliettiRidottiSud,
                CapienzaSala = Biglietteria.CapienzaSala
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string nome, string cognome, string sala, string tipoBiglietto)
        {
            if (Biglietteria.BigliettiVenduti.Count(b => b.Sala == sala) < Biglietteria.CapienzaSala)
            {
                Biglietto biglietto = new Biglietto
                {
                    Sala = sala,
                    Ridotto = tipoBiglietto == "Ridotto",
                    Utente = new Utente { Nome = nome, Cognome = cognome }
                };

                Biglietteria.BigliettiVenduti.Add(biglietto);
            }

            return RedirectToAction("Index");
        }
    }
}
