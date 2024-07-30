using Hotel.Models;
using Hotel.Interfaces;


namespace Hotel.Services
{
    public class PrenotazioneServizioService : IPrenotazioneServizioService
    {
        private readonly IPrenotazioneServizioRepository _prenotazioneServizioRepository;

        public PrenotazioneServizioService(IPrenotazioneServizioRepository prenotazioneServizioRepository)
        {
            _prenotazioneServizioRepository = prenotazioneServizioRepository;
        }

        public async Task<IEnumerable<PrenotazioneServizio>> GetAllPrenotazioneServiziAsync()
        {
            return await _prenotazioneServizioRepository.GetAllPrenotazioneServiziAsync();
        }

        public async Task<PrenotazioneServizio> GetPrenotazioneServizioByIdAsync(int id)
        {
            return await _prenotazioneServizioRepository.GetPrenotazioneServizioByIdAsync(id);
        }

        public async Task AddPrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio)
        {
            await _prenotazioneServizioRepository.AddPrenotazioneServizioAsync(prenotazioneServizio);
        }

        public async Task UpdatePrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio)
        {
            await _prenotazioneServizioRepository.UpdatePrenotazioneServizioAsync(prenotazioneServizio);
        }

        public async Task DeletePrenotazioneServizioAsync(int id)
        {
            await _prenotazioneServizioRepository.DeletePrenotazioneServizioAsync(id);
        }
    }
}
