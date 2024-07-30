using Hotel.Interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    [Authorize]
    public class PrenotazioneController : Controller
    {
        private readonly IPrenotazioneService _prenotazioneService;
        private readonly ICameraService _cameraService;
        private readonly IClienteService _clienteService;
        private readonly IServizioService _servizioService;

        public PrenotazioneController(IPrenotazioneService prenotazioneService, ICameraService cameraService, IClienteService clienteService, IServizioService servizioService)
        {
            _prenotazioneService = prenotazioneService;
            _cameraService = cameraService;
            _clienteService = clienteService;
            _servizioService = servizioService;
        }

        public async Task<IActionResult> Index()
        {
            var prenotazioni = await _prenotazioneService.GetAllPrenotazioniAsync();
            return View(prenotazioni);
        }

        public async Task<IActionResult> Details(int id)
        {
            var prenotazione = await _prenotazioneService.GetPrenotazioneByIdAsync(id);
            if (prenotazione == null)
            {
                return NotFound();
            }
            return View(prenotazione);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Clienti = await _clienteService.GetAllClientesAsync();
            ViewBag.TipologieCamere = await _cameraService.GetAllTipologieCamereAsync();
            ViewBag.DettagliSoggiorno = await _prenotazioneService.GetAllDettagliSoggiornoAsync();
            ViewBag.Servizi = await _servizioService.GetAllServiziAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Prenotazione prenotazione, int[] serviziSelezionati, int[] quantita)
        {
            if (ModelState.IsValid)
            {
                prenotazione.PrenotazioneServizi = new List<PrenotazioneServizio>();

                for (int i = 0; i < serviziSelezionati.Length; i++)
                {
                    var servizio = await _servizioService.GetServizioByIdAsync(serviziSelezionati[i]);
                    prenotazione.PrenotazioneServizi.Add(new PrenotazioneServizio
                    {
                        ServizioId = servizio.Id,
                        Quantita = quantita[i],
                        Prezzo = servizio.Prezzo
                    });
                }

                prenotazione.PrezzoTariffa = prenotazione.CalcolaPrezzoTotale();
                await _prenotazioneService.AddPrenotazioneAsync(prenotazione);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Clienti = await _clienteService.GetAllClientesAsync();
            ViewBag.TipologieCamere = await _cameraService.GetAllTipologieCamereAsync();
            ViewBag.DettagliSoggiorno = await _prenotazioneService.GetAllDettagliSoggiornoAsync();
            ViewBag.Servizi = await _servizioService.GetAllServiziAsync();
            return View(prenotazione);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var prenotazione = await _prenotazioneService.GetPrenotazioneByIdAsync(id);
            if (prenotazione == null)
            {
                return NotFound();
            }
            ViewBag.Clienti = await _clienteService.GetAllClientesAsync();
            ViewBag.TipologieCamere = await _cameraService.GetAllTipologieCamereAsync();
            ViewBag.DettagliSoggiorno = await _prenotazioneService.GetAllDettagliSoggiornoAsync();
            ViewBag.Servizi = await _servizioService.GetAllServiziAsync();
            return View(prenotazione);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Prenotazione prenotazione, int[] serviziSelezionati, int[] quantita)
        {
            if (ModelState.IsValid)
            {
                var existingPrenotazione = await _prenotazioneService.GetPrenotazioneByIdAsync(prenotazione.Id);
                if (existingPrenotazione == null)
                {
                    return NotFound();
                }

                existingPrenotazione.ClienteId = prenotazione.ClienteId;
                existingPrenotazione.CameraId = prenotazione.CameraId;
                existingPrenotazione.DataPrenotazione = prenotazione.DataPrenotazione;
                existingPrenotazione.NumeroProgressivo = prenotazione.NumeroProgressivo;
                existingPrenotazione.Anno = prenotazione.Anno;
                existingPrenotazione.Dal = prenotazione.Dal;
                existingPrenotazione.Al = prenotazione.Al;
                existingPrenotazione.CaparraConfirmatoria = prenotazione.CaparraConfirmatoria;
                existingPrenotazione.PrezzoTariffa = prenotazione.PrezzoTariffa;
                existingPrenotazione.DettagliSoggiornoId = prenotazione.DettagliSoggiornoId;
                existingPrenotazione.ImmagineCover = prenotazione.ImmagineCover;
                existingPrenotazione.TipologiaCameraId = prenotazione.TipologiaCameraId;

                existingPrenotazione.PrenotazioneServizi.Clear();
                for (int i = 0; i < serviziSelezionati.Length; i++)
                {
                    var servizio = await _servizioService.GetServizioByIdAsync(serviziSelezionati[i]);
                    existingPrenotazione.PrenotazioneServizi.Add(new PrenotazioneServizio
                    {
                        ServizioId = servizio.Id,
                        Quantita = quantita[i],
                        Prezzo = servizio.Prezzo
                    });
                }

                existingPrenotazione.PrezzoTariffa = existingPrenotazione.CalcolaPrezzoTotale();
                await _prenotazioneService.UpdatePrenotazioneAsync(existingPrenotazione);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Clienti = await _clienteService.GetAllClientesAsync();
            ViewBag.TipologieCamere = await _cameraService.GetAllTipologieCamereAsync();
            ViewBag.DettagliSoggiorno = await _prenotazioneService.GetAllDettagliSoggiornoAsync();
            ViewBag.Servizi = await _servizioService.GetAllServiziAsync();
            return View(prenotazione);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var prenotazione = await _prenotazioneService.GetPrenotazioneByIdAsync(id);
            if (prenotazione == null)
            {
                return NotFound();
            }
            return View(prenotazione);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _prenotazioneService.DeletePrenotazioneAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmedAjax(int id)
        {
            await _prenotazioneService.DeletePrenotazioneAsync(id);
            return Json(new { success = true });
        }

        [HttpGet]
        public async Task<JsonResult> GetCamereByTipologia(int tipologiaId)
        {
            var camere = await _cameraService.GetCamereByTipologiaAsync(tipologiaId);
            return Json(camere);
        }

        [HttpGet]
        public async Task<JsonResult> GetCameraDetails(int cameraId)
        {
            var camera = await _cameraService.GetCameraByIdAsync(cameraId);
            if (camera == null)
            {
                return Json(null);
            }

            var cameraDetails = new
            {
                descrizione = camera.Descrizione,
                postiLetto = camera.PostoLetto,
                prezzo = camera.Prezzo
            };
            return Json(cameraDetails);
        }
    }
}
