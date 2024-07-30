using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class PrenotazioneServizioController : Controller
    {
        private readonly IPrenotazioneServizioService _prenotazioneServizioService;

        public PrenotazioneServizioController(IPrenotazioneServizioService prenotazioneServizioService)
        {
            _prenotazioneServizioService = prenotazioneServizioService;
        }

        public async Task<IActionResult> Index()
        {
            var prenotazioneServizi = await _prenotazioneServizioService.GetAllPrenotazioneServiziAsync();
            return View(prenotazioneServizi);
        }

        public async Task<IActionResult> Details(int id)
        {
            var prenotazioneServizio = await _prenotazioneServizioService.GetPrenotazioneServizioByIdAsync(id);
            if (prenotazioneServizio == null)
            {
                return NotFound();
            }
            return View(prenotazioneServizio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PrenotazioneServizio prenotazioneServizio)
        {
            if (ModelState.IsValid)
            {
                await _prenotazioneServizioService.AddPrenotazioneServizioAsync(prenotazioneServizio);
                return RedirectToAction(nameof(Index));
            }
            return View(prenotazioneServizio);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var prenotazioneServizio = await _prenotazioneServizioService.GetPrenotazioneServizioByIdAsync(id);
            if (prenotazioneServizio == null)
            {
                return NotFound();
            }
            return View(prenotazioneServizio);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PrenotazioneServizio prenotazioneServizio)
        {
            if (ModelState.IsValid)
            {
                await _prenotazioneServizioService.UpdatePrenotazioneServizioAsync(prenotazioneServizio);
                return RedirectToAction(nameof(Index));
            }
            return View(prenotazioneServizio);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var prenotazioneServizio = await _prenotazioneServizioService.GetPrenotazioneServizioByIdAsync(id);
            if (prenotazioneServizio == null)
            {
                return NotFound();
            }
            return View(prenotazioneServizio);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _prenotazioneServizioService.DeletePrenotazioneServizioAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
