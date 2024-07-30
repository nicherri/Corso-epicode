using Hotel.Interfaces;
using Hotel.Models;
using System.Data.SqlClient;

namespace Hotel.Repositories
{
    public class ServizioRepository : IServizioRepository
    {
        private readonly string _connectionString;

        public ServizioRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Servizio>> GetAllServiziAsync()
        {
            var servizi = new List<Servizio>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Servizio", connection);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        servizi.Add(new Servizio
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Prezzo = (decimal)reader["Prezzo"]
                        });
                    }
                }
            }
            return servizi;
        }

        public async Task<Servizio> GetServizioByIdAsync(int id)
        {
            Servizio servizio = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Servizio WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        servizio = new Servizio
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Prezzo = (decimal)reader["Prezzo"]
                        };
                    }
                }
            }
            return servizio;
        }

        public async Task AddServizioAsync(Servizio servizio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Servizio (Nome, Prezzo) VALUES (@Nome, @Prezzo)", connection);
                command.Parameters.AddWithValue("@Nome", servizio.Nome);
                command.Parameters.AddWithValue("@Prezzo", servizio.Prezzo);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateServizioAsync(Servizio servizio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Servizio SET Nome = @Nome, Prezzo = @Prezzo WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Nome", servizio.Nome);
                command.Parameters.AddWithValue("@Prezzo", servizio.Prezzo);
                command.Parameters.AddWithValue("@Id", servizio.Id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteServizioAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Servizio WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
