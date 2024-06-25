using Npgsql;
using System.Configuration;

namespace FormView.Database
{
    public static class DbInit
    {
        public static string _connectionString;
        static DbInit()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
        }

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                return new NpgsqlConnection(_connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a conexão Npgsql: {ex.Message}");
                throw;
            }
        }
    }
}
