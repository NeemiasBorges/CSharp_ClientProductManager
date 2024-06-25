using Dominio.Entidades;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;

namespace Repositorio.Infra
{
    public class EnderecoRepositorio : IInfraEnderecoInterface
    {
        private string _stringConnection = "";
        private Conexao conn = new Conexao();
        public EnderecoRepositorio(string connectionString)
        {
            _stringConnection = connectionString;
        }

        public async Task<int> Adicionar(Endereco entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"INSERT INTO Endereco (nome) VALUES ('{entidade.vlrEndereco}') RETURNING id", conn))
                {

                    var id = await cmd.ExecuteScalarAsync();
                    return Convert.ToInt32(id);
                }
            }
        }

        public async Task Atualizar(Endereco entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("UPDATE Endereco SET nome = @Nome WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrEndereco);
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Deletar(Endereco entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("DELETE FROM Endereco WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<Endereco>> Listar()
        {
            List<Endereco> enderecoList = new List<Endereco>();
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Endereco", conn))
                {
                    var lista = new List<Endereco>();
                    var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        Endereco end = new Endereco();
                        lista.Add(end.DbToEntidade(reader));
                    }

                    return lista;
                }
            }
        }

        public async Task<Endereco> ListarPorId(int id)
        {
            Endereco end = new Endereco();
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Endereco WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", id);

                    var reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                        end = end.DbToEntidade(reader);
                }
            }
            return end;
        }
    }
}
