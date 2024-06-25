using Dominio.Entidades;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;

namespace Repositorio.Infra
{
    public class ContatoRepositorio : IInfraContatoInterface
    {
        private string _stringConnection = "";
        private Conexao conn = new Conexao();
        public ContatoRepositorio(string connectionString)
        {
            _stringConnection = connectionString;
        }
        public async Task<int> Adicionar(Contato entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("INSERT INTO Contato (nome) VALUES (@Nome) RETURNING id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrContato);

                    var id = await cmd.ExecuteScalarAsync();
                    return Convert.ToInt32(id);
                }
            }
        }


        public async Task Atualizar(Contato entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("UPDATE Contato SET nome = @Nome WHERE id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrContato);
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Deletar(Contato entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("DELETE FROM Contato WHERE id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<Contato>> Listar()
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT id, nome FROM Contato", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    var contatos = new List<Contato>();

                    while (await reader.ReadAsync())
                    {
                        Contato ct = new Contato();
                        contatos.Add(ct.DbToEntidade(reader));
                    }

                    return contatos;
                }
            }
        }

        public async Task<Contato> ListarPorId(int id)
        {
            Contato contato = new Contato();
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT id, nome FROM Contato WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", id);

                    var reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        contato = contato.DbToEntidade(reader);
                    }
                }
            }
            return contato;
        }
    }
}
