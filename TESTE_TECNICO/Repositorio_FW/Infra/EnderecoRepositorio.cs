using Dominio.Entidades;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"INSERT INTO Endereco (nome) VALUES ('{entidade.vlrEndereco}') RETURNING id", conn))
                {
                    var id = await cmd.ExecuteScalarAsync();
                    return Convert.ToInt32(id);
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

        public async Task Atualizar(Endereco entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("UPDATE Endereco SET nome = @Nome WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrEndereco);
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

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

        public async Task Deletar(Endereco entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("DELETE FROM Endereco WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", entidade.Id);

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

        public async Task<List<Endereco>> Listar()
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Endereco", conn))
                {
                    var enderecoList = new List<Endereco>();
                    var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        Endereco end = new Endereco();
                        enderecoList.Add(end.DbToEntidade(reader));
                    }

                    return enderecoList;
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

        public async Task<Endereco> ListarPorId(int id)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Endereco WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", id);

                    var reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        Endereco end = new Endereco();
                        end = end.DbToEntidade(reader);
                        return end;
                    }
                    else
                    {
                        return null;
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
        }
    }
}
