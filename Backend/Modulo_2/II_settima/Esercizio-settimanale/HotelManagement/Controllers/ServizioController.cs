using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class ServizioController : Controller
    {
        private readonly IServizioService _servizioService;

        public ServizioController(IServizioService servizioService)
        {
            _servizioService = servizioService;
        }

        public async Task<IActionResult> Index()
        {
            var servizi = await _servizioService.GetAllServiziAsync();
            return View(servizi);
        }

        public async Task<IActionResult> Details(int id)
        {
            var servizio = await _servizioService.GetServizioByIdAsync(id);
            if (servizio == null)
            {
                return NotFound();
            }
            return View(servizio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Servizio servizio)
        {
            if (ModelState.IsValid)
            {
                await _servizioService.AddServizioAsync(servizio);
                return RedirectToAction(nameof(Index));
            }
            return View(servizio);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var servizio = await _servizioService.GetServizioByIdAsync(id);
            if (servizio == null)
            {
                return NotFound();
            }
            return View(servizio);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Servizio servizio)
        {
            if (ModelState.IsValid)
            {
                await _servizioService.UpdateServizioAsync(servizio);
                return RedirectToAction(nameof(Index));
            }
            return View(servizio);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var servizio = await _servizioService.GetServizioByIdAsync(id);
            if (servizio == null)
            {
                return NotFound();
            }
            return View(servizio);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _servizioService.DeleteServizioAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
