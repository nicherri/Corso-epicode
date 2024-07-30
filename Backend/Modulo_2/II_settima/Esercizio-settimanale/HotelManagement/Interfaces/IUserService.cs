using Hotel.Models;

namespace Hotel.Interfaces
{
    public interface IUserService
    {
        Task<Utente> ValidateUserAsync(string username, string password);
        Task<bool> RegisterUserAsync(Utente utente);
    }
}
