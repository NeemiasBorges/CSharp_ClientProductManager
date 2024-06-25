﻿using Dominio.Entidades;
using Repositorio.Infra.Util;
using Repositorio.Interfaces;
using Npgsql;
using System.Reflection.Metadata;

namespace Repositorio.Infra
{
    public class ProdutoRepositorio : IInfraProdutoInterface
    {
        private string _stringConnection = "";
        private Conexao conn = new Conexao();
        public ProdutoRepositorio(string connectionString)
        {
            _stringConnection = connectionString;
        }
        public async Task Adicionar(Produto entidade)
        {
            try
            {
                await using (var conn = new NpgsqlConnection(_stringConnection))
                {
                    await conn.OpenAsync();

                    using (var cmd = new NpgsqlCommand($"INSERT INTO Produto (Nome, Descricao, Preco) VALUES ('{entidade.nome}', '{entidade.descricao}', {entidade.preco})", conn))
                        await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception e)
            {
            }
        }

        public async Task Atualizar(Produto entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"UPDATE Produto SET Nome = '{entidade.nome}', Descricao = '{entidade.descricao}', Preco = {entidade.preco} WHERE Id = {entidade.id}", conn))
                    await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task Deletar(Produto entidade)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"DELETE FROM Produto WHERE Id = {entidade.id}", conn))
                    await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<Produto>> Listar()
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Produto", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    List<Produto> produto_list = new List<Produto>();
                    while (await reader.ReadAsync())
                    {
                        Produto produto = new Produto();
                        produto_list.Add(produto.DbToEntidade(reader));
                    }
                    return produto_list;
                }
            }
        }

        public async Task<Produto> ListarPorId(int id)
        {
            await using (var conn = new NpgsqlConnection(_stringConnection))
            {
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"SELECT * FROM Produto WHERE Id = {id}", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    Produto produto = new Produto();
                    while (await reader.ReadAsync())
                        produto = produto.DbToEntidade(reader);

                    return produto;
                }
            }
        }
    }
}
