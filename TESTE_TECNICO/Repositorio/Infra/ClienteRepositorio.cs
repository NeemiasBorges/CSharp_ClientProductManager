using Dominio.Entidades;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;

namespace Repositorio.Infra
{
    public class ClienteRepositorio : IClienteInterface
    {
        private string _connectionString = "";
        private Conexao conn = new Conexao();
        public ClienteRepositorio(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Adicionar(Cliente entidade)
        {
            await using (var conn = new NpgsqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"INSERT INTO Cliente (Nome, Id_Endereco, Id_Telefone, Email) VALUES ('{entidade.nome}', {entidade.id_endereco}, {entidade.id_telefone}, '{entidade.email}')", conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Atualizar(Cliente entidade)
        {
            await using ( var conn = new NpgsqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"UPDATE Cliente SET Nome = '{entidade.nome}', Id_Endereco = {entidade.id_endereco}, Id_Telefone = {entidade.id_telefone}, Email = '{entidade.email}' WHERE Id = {entidade.id}", conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Deletar(Cliente entidade)
        {
            await using (var conn = new NpgsqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"DELETE FROM Cliente WHERE Id = {entidade.id}", conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }   
        }

        public async Task<List<Cliente>> Listar()
        {
            List<Cliente> cliente_list = new List<Cliente>();
            Cliente clitente = new Cliente();

            await using (var conn = new NpgsqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Cliente", conn))
                await using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        cliente_list.Add(clitente.DbToEntidade(reader));
                    }
                }
            }

            return cliente_list;
        }

        public async Task<Cliente> ListarPorId(int id)
        {
            Cliente cliente               = new Cliente();
            NpgsqlDataSource InternalConn = await conn.RetornaConexao(_connectionString);

            await using (var cmd    = InternalConn.CreateCommand($"SELECT * FROM Cliente WHERE Id = {id}"))
            await using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    cliente = cliente.DbToEntidade(reader);
                }
            }

            return cliente;
        }
    }
}
