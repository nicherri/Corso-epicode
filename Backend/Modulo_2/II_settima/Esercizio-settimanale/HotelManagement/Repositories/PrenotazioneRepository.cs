using Hotel.Interfaces;
using Hotel.Models;
using System.Data.SqlClient;
namespace Hotel.Repositories
{
    public class PrenotazioneRepository : IPrenotazioneRepository
    {
        private readonly string _connectionString;

        public PrenotazioneRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Prenotazione>> GetAllPrenotazioniAsync()
        {
            var prenotazioni = new List<Prenotazione>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Prenotazione", connection);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        prenotazioni.Add(new Prenotazione
                        {
                            Id = (int)reader["Id"],
                            ClienteId = (int)reader["ClienteId"],
                            CameraId = (int)reader["CameraId"],
                            DataPrenotazione = (DateTime)reader["DataPrenotazione"],
                            NumeroProgressivo = (int)reader["NumeroProgressivo"],
                            Anno = (int)reader["Anno"],
                            Dal = (DateTime)reader["Dal"],
                            Al = (DateTime)reader["Al"],
                            CaparraConfirmatoria = (decimal)reader["CaparraConfirmatoria"],
                            PrezzoTariffa = (decimal)reader["PrezzoTariffa"],
                            DettagliSoggiornoId = (int)reader["DettagliSoggiornoId"],
                            ImmagineCover = reader["ImmagineCover"].ToString(),
                            TipologiaCameraId = (int)reader["TipologiaCameraId"]
                        });
                    }
                }
            }
            return prenotazioni;
        }

        public async Task<Prenotazione> GetPrenotazioneByIdAsync(int id)
        {
            Prenotazione prenotazione = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Prenotazione WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        prenotazione = new Prenotazione
                        {
                            Id = (int)reader["Id"],
                            ClienteId = (int)reader["ClienteId"],
                            CameraId = (int)reader["CameraId"],
                            DataPrenotazione = (DateTime)reader["DataPrenotazione"],
                            NumeroProgressivo = (int)reader["NumeroProgressivo"],
                            Anno = (int)reader["Anno"],
                            Dal = (DateTime)reader["Dal"],
                            Al = (DateTime)reader["Al"],
                            CaparraConfirmatoria = (decimal)reader["CaparraConfirmatoria"],
                            PrezzoTariffa = (decimal)reader["PrezzoTariffa"],
                            DettagliSoggiornoId = (int)reader["DettagliSoggiornoId"],
                            ImmagineCover = reader["ImmagineCover"].ToString(),
                            TipologiaCameraId = (int)reader["TipologiaCameraId"]
                        };
                    }
                }
            }
            return prenotazione;
        }

        public async Task AddPrenotazioneAsync(Prenotazione prenotazione)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("INSERT INTO Prenotazione (ClienteId, CameraId, DataPrenotazione, NumeroProgressivo, Anno, Dal, Al, CaparraConfirmatoria, PrezzoTariffa, DettagliSoggiornoId, ImmagineCover, TipologiaCameraId) VALUES (@ClienteId, @CameraId, @DataPrenotazione, @NumeroProgressivo, @Anno, @Dal, @Al, @CaparraConfirmatoria, @PrezzoTariffa, @DettagliSoggiornoId, @ImmagineCover, @TipologiaCameraId)", connection);
                command.Parameters.AddWithValue("@ClienteId", prenotazione.ClienteId);
                command.Parameters.AddWithValue("@CameraId", prenotazione.CameraId);
                command.Parameters.AddWithValue("@DataPrenotazione", prenotazione.DataPrenotazione);
                command.Parameters.AddWithValue("@NumeroProgressivo", prenotazione.NumeroProgressivo);
                command.Parameters.AddWithValue("@Anno", prenotazione.Anno);
                command.Parameters.AddWithValue("@Dal", prenotazione.Dal);
                command.Parameters.AddWithValue("@Al", prenotazione.Al);
                command.Parameters.AddWithValue("@CaparraConfirmatoria", prenotazione.CaparraConfirmatoria);
                command.Parameters.AddWithValue("@PrezzoTariffa", prenotazione.PrezzoTariffa);
                command.Parameters.AddWithValue("@DettagliSoggiornoId", prenotazione.DettagliSoggiornoId);
                command.Parameters.AddWithValue("@ImmagineCover", prenotazione.ImmagineCover);
                command.Parameters.AddWithValue("@TipologiaCameraId", prenotazione.TipologiaCameraId);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdatePrenotazioneAsync(Prenotazione prenotazione)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("UPDATE Prenotazione SET ClienteId = @ClienteId, CameraId = @CameraId, DataPrenotazione = @DataPrenotazione, NumeroProgressivo = @NumeroProgressivo, Anno = @Anno, Dal = @Dal, Al = @Al, CaparraConfirmatoria = @CaparraConfirmatoria, PrezzoTariffa = @PrezzoTariffa, DettagliSoggiornoId = @DettagliSoggiornoId, ImmagineCover = @ImmagineCover, TipologiaCameraId = @TipologiaCameraId WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@ClienteId", prenotazione.ClienteId);
                command.Parameters.AddWithValue("@CameraId", prenotazione.CameraId);
                command.Parameters.AddWithValue("@DataPrenotazione", prenotazione.DataPrenotazione);
                command.Parameters.AddWithValue("@NumeroProgressivo", prenotazione.NumeroProgressivo);
                command.Parameters.AddWithValue("@Anno", prenotazione.Anno);
                command.Parameters.AddWithValue("@Dal", prenotazione.Dal);
                command.Parameters.AddWithValue("@Al", prenotazione.Al);
                command.Parameters.AddWithValue("@CaparraConfirmatoria", prenotazione.CaparraConfirmatoria);
                command.Parameters.AddWithValue("@PrezzoTariffa", prenotazione.PrezzoTariffa);
                command.Parameters.AddWithValue("@DettagliSoggiornoId", prenotazione.DettagliSoggiornoId);
                command.Parameters.AddWithValue("@ImmagineCover", prenotazione.ImmagineCover);
                command.Parameters.AddWithValue("@TipologiaCameraId", prenotazione.TipologiaCameraId);
                command.Parameters.AddWithValue("@Id", prenotazione.Id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeletePrenotazioneAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("DELETE FROM Prenotazione WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
