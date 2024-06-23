using Npgsql;

namespace Repositorio.Infra.Util
{
    public class Conexao
    {
        public async Task<NpgsqlDataSource> RetornaConexao(string _connectionString)
        {
            try
            {
                await using var dataSource = NpgsqlDataSource.Create(_connectionString);

                return dataSource;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro de conexao com o Banco, verifique: {e.Message}");
            }
        }
    }
}
