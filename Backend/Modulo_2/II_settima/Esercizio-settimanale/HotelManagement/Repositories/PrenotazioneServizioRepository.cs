using Hotel.Interfaces;
using Hotel.Models;
using System.Data.SqlClient;


namespace Hotel.Repositories
{
    public class PrenotazioneServizioRepository : IPrenotazioneServizioRepository
    {
        private readonly string _connectionString;

        public PrenotazioneServizioRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<PrenotazioneServizio>> GetAllPrenotazioneServiziAsync()
        {
            var prenotazioneServizi = new List<PrenotazioneServizio>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM PrenotazioneServizio", connection);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        prenotazioneServizi.Add(new PrenotazioneServizio
                        {
                            Id = (int)reader["Id"],
                            PrenotazioneId = (int)reader["PrenotazioneId"],
                            ServizioId = (int)reader["ServizioId"],
                            Data = (DateTime)reader["Data"],
                            Quantita = (int)reader["Quantita"],
                            Prezzo = (decimal)reader["Prezzo"]
                        });
                    }
                }
            }
            return prenotazioneServizi;
        }

        public async Task<PrenotazioneServizio> GetPrenotazioneServizioByIdAsync(int id)
        {
            PrenotazioneServizio prenotazioneServizio = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM PrenotazioneServizio WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        prenotazioneServizio = new PrenotazioneServizio
                        {
                            Id = (int)reader["Id"],
                            PrenotazioneId = (int)reader["PrenotazioneId"],
                            ServizioId = (int)reader["ServizioId"],
                            Data = (DateTime)reader["Data"],
                            Quantita = (int)reader["Quantita"],
                            Prezzo = (decimal)reader["Prezzo"]
                        };
                    }
                }
            }
            return prenotazioneServizio;
        }

        public async Task AddPrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO PrenotazioneServizio (PrenotazioneId, ServizioId, Data, Quantita, Prezzo) VALUES (@PrenotazioneId, @ServizioId, @Data, @Quantita, @Prezzo)", connection);
                command.Parameters.AddWithValue("@PrenotazioneId", prenotazioneServizio.PrenotazioneId);
                command.Parameters.AddWithValue("@ServizioId", prenotazioneServizio.ServizioId);
                command.Parameters.AddWithValue("@Data", prenotazioneServizio.Data);
                command.Parameters.AddWithValue("@Quantita", prenotazioneServizio.Quantita);
                command.Parameters.AddWithValue("@Prezzo", prenotazioneServizio.Prezzo);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdatePrenotazioneServizioAsync(PrenotazioneServizio prenotazioneServizio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE PrenotazioneServizio SET PrenotazioneId = @PrenotazioneId, ServizioId = @ServizioId, Data = @Data, Quantita = @Quantita, Prezzo = @Prezzo WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@PrenotazioneId", prenotazioneServizio.PrenotazioneId);
                command.Parameters.AddWithValue("@ServizioId", prenotazioneServizio.ServizioId);
                command.Parameters.AddWithValue("@Data", prenotazioneServizio.Data);
                command.Parameters.AddWithValue("@Quantita", prenotazioneServizio.Quantita);
                command.Parameters.AddWithValue("@Prezzo", prenotazioneServizio.Prezzo);
                command.Parameters.AddWithValue("@Id", prenotazioneServizio.Id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeletePrenotazioneServizioAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM PrenotazioneServizio WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
