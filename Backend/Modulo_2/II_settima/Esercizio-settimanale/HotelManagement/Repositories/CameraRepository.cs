using Hotel.Interfaces;
using Hotel.Models;
using System.Data.SqlClient;


namespace Hotel.Repositories
{
    public class CameraRepository : ICameraRepository
    {
        private readonly string _connectionString;

        public CameraRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<TipologiaCamera>> GetAllTipologieCamereAsync()
        {
            var tipologie = new List<TipologiaCamera>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM TipologiaCamera", connection);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        tipologie.Add(new TipologiaCamera
                        {
                            Id = (int)reader["Id"],
                            Nome = reader["Nome"].ToString(),
                            Immagine = reader["Immagine"].ToString()
                        });
                    }
                }
            }
            return tipologie;
        }

        public async Task<IEnumerable<Camera>> GetCamereByTipologiaAsync(int tipologiaId)
        {
            var camere = new List<Camera>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Camera WHERE TipologiaCameraId = @TipologiaCameraId", connection);
                command.Parameters.AddWithValue("@TipologiaCameraId", tipologiaId);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        camere.Add(new Camera
                        {
                            Id = (int)reader["Id"],
                            Descrizione = reader["Descrizione"].ToString(),
                            PostoLetto = (int)reader["PostoLetto"],
                            Prezzo = (decimal)reader["Prezzo"],
                            TipologiaCameraId = (int)reader["TipologiaCameraId"]
                        });
                    }
                }
            }
            return camere;
        }

        public async Task<Camera> GetCameraByIdAsync(int id)
        {
            Camera camera = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Camera WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        camera = new Camera
                        {
                            Id = (int)reader["Id"],
                            Descrizione = reader["Descrizione"].ToString(),
                            PostoLetto = (int)reader["PostoLetto"],
                            Prezzo = (decimal)reader["Prezzo"],
                            TipologiaCameraId = (int)reader["TipologiaCameraId"]
                        };
                    }
                }
            }
            return camera;
        }
    }
}
