using Dapper;
using Hotel.Interfaces;
using Hotel.Models;
using System.Data.SqlClient;

namespace Hotel.Services
{
    public class UserService : IUserService
    {
        private readonly string _connectionString;
        private readonly ILogger<UserService> _logger;

        public UserService(IConfiguration configuration, ILogger<UserService> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<Utente> ValidateUserAsync(string username, string password)
        {
            _logger.LogInformation($"Validating user: {username}, Password: {password}");

            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Utenti WHERE Username = @Username AND Password = @Password";
                var utente = await connection.QuerySingleOrDefaultAsync<Utente>(query, new { Username = username, Password = password });

                if (utente == null)
                {
                    _logger.LogWarning("User not found or incorrect password.");
                }
                else
                {
                    _logger.LogInformation($"User found: {utente.Username}");
                }

                return utente;
            }
        }

        public async Task<bool> RegisterUserAsync(Utente utente)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO Utenti (Username, Password, Nome, Cognome, CodiceFiscale, DataDiNascita, LuogoDiNascita, LuogoDiResidenza, Indirizzo, Email) " +
                            "VALUES (@Username, @Password, @Nome, @Cognome, @CodiceFiscale, @DataDiNascita, @LuogoDiNascita, @LuogoDiResidenza, @Indirizzo, @Email)";
                var result = await connection.ExecuteAsync(query, utente);
                return result > 0;
            }
        }
    }
}
