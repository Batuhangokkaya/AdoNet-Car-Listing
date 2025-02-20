using System.Data.SqlClient;

namespace Repositories
{
    public class RepositoryContext : IDisposable
    {
        private readonly SqlConnection _connection;

        public RepositoryContext()
        {
            _connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=CarAdvertisementDB;TrustServerCertificate=true;");
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        // IDisposable arayüzünü implemente ediyoruz
        public void Dispose()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            _connection?.Dispose(); // Belleği temizlemek için
        }
    }
}