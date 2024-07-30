using Hotel.Interfaces;
using Hotel.Models;

namespace Hotel.Services
{
    public class ServizioService : IServizioService
    {
        private readonly IServizioRepository _servizioRepository;

        public ServizioService(IServizioRepository servizioRepository)
        {
            _servizioRepository = servizioRepository;
        }

        public async Task<IEnumerable<Servizio>> GetAllServiziAsync()
        {
            return await _servizioRepository.GetAllServiziAsync();
        }

        public async Task<Servizio> GetServizioByIdAsync(int id)
        {
            return await _servizioRepository.GetServizioByIdAsync(id);
        }

        public async Task AddServizioAsync(Servizio servizio)
        {
            await _servizioRepository.AddServizioAsync(servizio);
        }

        public async Task UpdateServizioAsync(Servizio servizio)
        {
            await _servizioRepository.UpdateServizioAsync(servizio);
        }

        public async Task DeleteServizioAsync(int id)
        {
            await _servizioRepository.DeleteServizioAsync(id);
        }
    }
}
