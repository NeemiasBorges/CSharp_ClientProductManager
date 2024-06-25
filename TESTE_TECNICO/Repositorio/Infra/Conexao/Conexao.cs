using Npgsql;

namespace Repositorio.Infra.Util
{
    public class Conexao
    {
        private readonly string _connectionString;
        public Conexao(){}

        public async Task<NpgsqlConnection> RetornaConexao()
        {
            try
            {
                var conexao = new NpgsqlConnection(_connectionString);
                await conexao.OpenAsync();
                return conexao;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro de conexão com o Banco, verifique: {e.Message}");
            }
        }
    }
}
