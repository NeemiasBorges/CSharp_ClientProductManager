﻿using Dominio.Entidades;
using Npgsql;
using Repositorio.Interfaces;

namespace Repositorio.Infra
{
    public class VendaRepositorio : IVendaInterface
    {
        private string _StringConnection = "";
        public VendaRepositorio(){

        }
        public async Task Adicionar(Venda entidade)
        {
            await using (var conn = new NpgsqlConnection(_StringConnection))
            {
                await conn.OpenAsync();
                using (var transaction = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        var upsertVendaQuery = @"
                        INSERT INTO Venda (Id, Id_Cliente, Data, Id_Usuario) 
                        VALUES (@Id, @IdCliente, @DataCriacao, @IdUsuario)
                        ON CONFLICT (Id) DO UPDATE
                        SET Id_Cliente = EXCLUDED.Id_Cliente, 
                            Data = EXCLUDED.Data,
                            Id_Usuario = EXCLUDED.Id_Usuario
                        RETURNING Id;";

                        int vendaId;
                        await using (var cmd = new NpgsqlCommand(upsertVendaQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("Id", entidade.id);
                            cmd.Parameters.AddWithValue("IdCliente", entidade.id_cliente);
                            cmd.Parameters.AddWithValue("DataCriacao", DateTime.Now);
                            cmd.Parameters.AddWithValue("IdUsuario", entidade.id_usuario);

                            vendaId = (int)await cmd.ExecuteScalarAsync();
                        }

                        var upsertVendaCorpoQuery = @"
                        INSERT INTO VendaCorpo (Id, Id_Venda, Produto, Preco) 
                        VALUES (@Id, @IdVenda, @Produto, @Preco)
                        ON CONFLICT (Id) DO UPDATE
                        SET Id_Venda = EXCLUDED.Id_Venda, 
                            Produto = EXCLUDED.Descricao,
                            Preco = EXCLUDED.Preco;";

                        foreach (var vendaCorpo in entidade.listaCorpo)
                        {
                            await using (var cmd = new NpgsqlCommand(upsertVendaCorpoQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("Id", vendaCorpo.id_venda);
                                cmd.Parameters.AddWithValue("IdVenda", vendaId);
                                cmd.Parameters.AddWithValue("Produto", vendaCorpo.id_produto);
                                cmd.Parameters.AddWithValue("Preco", vendaCorpo.preco);

                                await cmd.ExecuteNonQueryAsync();
                            }
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        await transaction.RollbackAsync();
                        throw new Exception("Erro ao inserir a venda", e);
                    }
                }
            }
        }

        public async Task Atualizar(Venda entidade)
        {
            await using (var conn = new NpgsqlConnection(_StringConnection))
            {
                await conn.OpenAsync();
                using (var transaction = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        var upsertVendaQuery = @"
                        INSERT INTO Venda (Id, Id_Cliente, Data, Id_Usuario) 
                        VALUES (@Id, @IdCliente, @DataCriacao, @IdUsuario)
                        ON CONFLICT (Id) DO UPDATE
                        SET Id_Cliente = EXCLUDED.Id_Cliente, 
                            Data = EXCLUDED.Data,
                            Id_Usuario = EXCLUDED.Id_Usuario
                        RETURNING Id;";

                        int vendaId;
                        await using (var cmd = new NpgsqlCommand(upsertVendaQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("Id", entidade.id);
                            cmd.Parameters.AddWithValue("IdCliente", entidade.id_cliente);
                            cmd.Parameters.AddWithValue("DataCriacao", DateTime.Now);
                            cmd.Parameters.AddWithValue("IdUsuario", entidade.id_usuario);

                            vendaId = (int)await cmd.ExecuteScalarAsync();
                        }

                        var upsertVendaCorpoQuery = @"
                        INSERT INTO VendaCorpo (Id, Id_Venda, Produto, Preco) 
                        VALUES (@Id, @IdVenda, @Produto, @Preco)
                        ON CONFLICT (Id) DO UPDATE
                        SET Id_Venda = EXCLUDED.Id_Venda, 
                            Produto = EXCLUDED.Descricao,
                            Preco = EXCLUDED.Preco;";

                        foreach (var vendaCorpo in entidade.listaCorpo)
                        {
                            await using (var cmd = new NpgsqlCommand(upsertVendaCorpoQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("Id", vendaCorpo.id_venda);
                                cmd.Parameters.AddWithValue("IdVenda", vendaId);
                                cmd.Parameters.AddWithValue("Produto", vendaCorpo.id_produto);
                                cmd.Parameters.AddWithValue("Preco", vendaCorpo.preco);

                                await cmd.ExecuteNonQueryAsync();
                            }
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        await transaction.RollbackAsync();
                        throw new Exception("Erro ao atualizar a venda", e);
                    }
                }
            }
        }

        public async Task Deletar(Venda entidade)
        {
            await using (var conn = new NpgsqlConnection(_StringConnection))
            {
                await conn.OpenAsync();
                using (var transaction = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        var deleteVendaCorpoQuery = @"
                        DELETE FROM VendaCorpo WHERE Id_Venda = @IdVenda;";

                        await using (var cmd = new NpgsqlCommand(deleteVendaCorpoQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("IdVenda", entidade.id);

                            await cmd.ExecuteNonQueryAsync();
                        }

                        var deleteVendaQuery = @"
                        DELETE FROM Venda WHERE Id = @Id;";

                        await using (var cmd = new NpgsqlCommand(deleteVendaQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("Id", entidade.id);

                            await cmd.ExecuteNonQueryAsync();
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        await transaction.RollbackAsync();
                        throw new Exception("Erro ao deletar a venda", e);
                    }
                }
            }
        }

        public async Task<List<Venda>> Listar()
        {
            await using (var conn = new NpgsqlConnection(_StringConnection))
            {
                await conn.OpenAsync();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Venda", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    List<Venda> venda_list = new List<Venda>();
                    while (await reader.ReadAsync())
                    {
                        Venda venda = new Venda();
                        venda_list.Add(venda.DbToEntidade(reader));
                    }
                    return venda_list;
                }
            }
        }

        public async Task<Venda> ListarPorId(int id)
        {
            await using (var conn = new NpgsqlConnection(_StringConnection))
            {
                await conn.OpenAsync();
                using (var cmd = new NpgsqlCommand($"SELECT * FROM Venda WHERE Id = {id}", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    Venda venda = new Venda();
                    while (await reader.ReadAsync())
                        venda = venda.DbToEntidade(reader);
                    
                    return venda;
                }
            }
        }
    }
}