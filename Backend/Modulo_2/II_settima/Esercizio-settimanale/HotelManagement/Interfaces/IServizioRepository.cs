﻿using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IServizioRepository
    {
        Task<IEnumerable<Servizio>> GetAllServiziAsync();
        Task<Servizio> GetServizioByIdAsync(int id);
        Task AddServizioAsync(Servizio servizio);
        Task UpdateServizioAsync(Servizio servizio);
        Task DeleteServizioAsync(int id);
    }
}
