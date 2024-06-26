// Controllers/HomeController.cs
using Esercizio_del_giorno.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Esercizio_del_giorno.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
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
