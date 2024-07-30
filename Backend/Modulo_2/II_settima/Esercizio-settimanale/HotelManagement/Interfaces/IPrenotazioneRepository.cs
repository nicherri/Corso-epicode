using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IPrenotazioneRepository
    {
        Task<IEnumerable<Prenotazione>> GetAllPrenotazioniAsync();
        Task<Prenotazione> GetPrenotazioneByIdAsync(int id);
        Task AddPrenotazioneAsync(Prenotazione prenotazione);
        Task UpdatePrenotazioneAsync(Prenotazione prenotazione);
        Task DeletePrenotazioneAsync(int id);
    }
}
