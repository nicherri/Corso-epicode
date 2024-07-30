using Hotel.Interfaces;
using Hotel.Models;
namespace Hotel.Services
{
    public class PrenotazioneService : IPrenotazioneService
    {
        private readonly IPrenotazioneRepository _prenotazioneRepository;
        private readonly IRepository<DettagliSoggiorno> _dettagliSoggiornoRepository;

        public PrenotazioneService(IPrenotazioneRepository prenotazioneRepository, IRepository<DettagliSoggiorno> dettagliSoggiornoRepository)
        {
            _prenotazioneRepository = prenotazioneRepository;
            _dettagliSoggiornoRepository = dettagliSoggiornoRepository;
        }

        public async Task<IEnumerable<Prenotazione>> GetAllPrenotazioniAsync()
        {
            return await _prenotazioneRepository.GetAllPrenotazioniAsync();
        }

        public async Task<Prenotazione> GetPrenotazioneByIdAsync(int id)
        {
            return await _prenotazioneRepository.GetPrenotazioneByIdAsync(id);
        }

        public async Task AddPrenotazioneAsync(Prenotazione prenotazione)
        {
            await _prenotazioneRepository.AddPrenotazioneAsync(prenotazione);
        }

        public async Task UpdatePrenotazioneAsync(Prenotazione prenotazione)
        {
            await _prenotazioneRepository.UpdatePrenotazioneAsync(prenotazione);
        }

        public async Task DeletePrenotazioneAsync(int id)
        {
            await _prenotazioneRepository.DeletePrenotazioneAsync(id);
        }

        public async Task<IEnumerable<DettagliSoggiorno>> GetAllDettagliSoggiornoAsync()
        {
            return await _dettagliSoggiornoRepository.GetAllAsync();
        }
    }
}
