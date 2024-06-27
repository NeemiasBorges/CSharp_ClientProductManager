using Dominio.Entidades;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositorio.Infra
{
    public class ClienteRepositorio : IInfraClienteInterface
    {
        private string _connectionString = "";
        private Conexao conn = new Conexao();
        public ClienteRepositorio(string connectionSTRING)
        {
            _connectionString = connectionSTRING;
        }

        public async Task Adicionar(Cliente entidade)
        {
            NpgsqlConnection conn = null;

            try
            {
                conn = new NpgsqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = $"INSERT INTO clientes (nome, id_endereco, id_telefone, email) VALUES (@nome, @id_endereco, @id_telefone, @email)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", entidade.nome);
                    cmd.Parameters.AddWithValue("@id_endereco", entidade.id_endereco);
                    cmd.Parameters.AddWithValue("@id_telefone", entidade.id_telefone);
                    cmd.Parameters.AddWithValue("@email", entidade.email);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task Atualizar(Cliente entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = $"UPDATE clientes SET Nome = '{entidade.nome}', Id_Endereco = {entidade.id_endereco}, Id_Telefone = {entidade.id_telefone}, Email = '{entidade.email}' WHERE Id = {entidade.id}";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }


        public async Task Deletar(Cliente entidade)
        {

            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = $"DELETE FROM clientes WHERE Id = {entidade.id}";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task<List<Cliente>> Listar()
        {
            List<Cliente> cliente_list = new List<Cliente>();
            Cliente cliente = new Cliente();
            NpgsqlConnection conn = null;

            try
            {
                conn = new NpgsqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = "SELECT * FROM clientes";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            cliente_list.Add(cliente.DbToEntidade(reader));
                        }
                    }
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return cliente_list;
        }

        public async Task<Cliente> ListarPorId(int id)
        {
            Cliente cliente = new Cliente();
            NpgsqlConnection conn = null;

            try
            {
                conn = new NpgsqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = "SELECT * FROM Clientes WHERE Id = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            cliente = cliente.DbToEntidade(reader);
                        }
                    }
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return cliente;
        }
    }
}
