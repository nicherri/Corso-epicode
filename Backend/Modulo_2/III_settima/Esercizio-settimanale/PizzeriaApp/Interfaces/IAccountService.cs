using Models;
using ViewModels;

namespace Interfaces
{
    public interface IAccountService
    {
        Task<bool> RegisterAsync(RegisterViewModel model);
        Task<bool> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
        Task<Utente> GetUserAsync(string email);
    }
}
