using Dapper;
using Hotel.Interfaces;
using System.Data.SqlClient;

namespace Hotel.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly string _connectionString;

        public Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM {typeof(T).Name}";
                return await connection.QueryAsync<T>(query);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"SELECT * FROM {typeof(T).Name} WHERE Id = @Id";
                return await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });
            }
        }

        public async Task AddAsync(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = GenerateInsertQuery();
                await connection.ExecuteAsync(query, entity);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = GenerateUpdateQuery();
                await connection.ExecuteAsync(query, entity);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"DELETE FROM {typeof(T).Name} WHERE Id = @Id";
                await connection.ExecuteAsync(query, new { Id = id });
            }
        }

        private string GenerateInsertQuery()
        {
            var tableName = typeof(T).Name;
            var properties = typeof(T).GetProperties();
            var columns = string.Join(", ", properties.Select(p => p.Name));
            var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));
            return $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
        }

        private string GenerateUpdateQuery()
        {
            var tableName = typeof(T).Name;
            var properties = typeof(T).GetProperties().Where(p => p.Name != "Id");
            var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
            return $"UPDATE {tableName} SET {setClause} WHERE Id = @Id";
        }
    }
}
