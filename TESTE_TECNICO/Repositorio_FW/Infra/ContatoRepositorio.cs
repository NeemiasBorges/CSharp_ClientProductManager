using Dominio.Entidades;
using Npgsql;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("INSERT INTO Contato (nome) VALUES (@Nome) RETURNING id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrContato);

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

        public async Task Atualizar(Contato entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("UPDATE Contato SET nome = @Nome WHERE id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Nome", entidade.vlrContato);
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

        public async Task Deletar(Contato entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("DELETE FROM Contato WHERE id = @Id", conn))
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

        public async Task<List<Contato>> Listar()
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
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
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task<Contato> ListarPorId(int id)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_stringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT id, nome FROM Contato WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("Id", id);

                    var reader = await cmd.ExecuteReaderAsync();

                    if (await reader.ReadAsync())
                    {
                        Contato contato = new Contato();
                        contato = contato.DbToEntidade(reader);
                        return contato;
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
