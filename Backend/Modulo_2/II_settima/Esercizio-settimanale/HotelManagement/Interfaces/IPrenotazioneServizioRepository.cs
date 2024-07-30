using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IPrenotazioneServizioRepository
    {
        Task<IEnumerable<PrenotazioneServizio>> GetAllPrenotazioneServiziAsync();
        Task<PrenotazioneServizio> GetPrenotazioneServizioByIdAsync(int id);
        Task AddPrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio);
        Task UpdatePrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio);
        Task DeletePrenotazioneServizioAsync(int id);
    }
}
