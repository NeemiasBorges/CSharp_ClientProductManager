using Dominio.Entidades;
using Npgsql;
using Repositorio.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Repositorio.Infra
{
    public class VendaRepositorio : IInfraVendaInterface
    {
        private string _StringConnection = "";
        public VendaRepositorio(string connectionString)
        {
            _StringConnection = connectionString;
        }

        public async Task Adicionar(Venda entidade)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        var upsertVendaQuery = @"
                INSERT INTO Vendas (Id_Cliente, Data_Criacao, Id_Usuario) 
                VALUES (@IdCliente, @DataCriacao, @IdUsuario)
                ON CONFLICT (Id) DO UPDATE
                SET Id_Cliente = EXCLUDED.Id_Cliente, 
                    Data_Criacao = EXCLUDED.Data_Criacao,
                    Id_Usuario = EXCLUDED.Id_Usuario
                RETURNING Id;";

                        int vendaId;
                        using (var cmd = new NpgsqlCommand(upsertVendaQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("IdCliente", entidade.id_cliente);
                            cmd.Parameters.AddWithValue("DataCriacao", entidade.data_Criacao);
                            cmd.Parameters.AddWithValue("IdUsuario", entidade.id_usuario);

                            vendaId = (int)await cmd.ExecuteScalarAsync();
                        }

                        var upsertVendaCorpoQuery = @"
                INSERT INTO VendasCorpo (Id_Venda, Id_Produto, Preco, Quantidade) 
                VALUES (@IdVenda, @Produto, @Preco, @Quantidade)
                ON CONFLICT (Id) DO UPDATE
                SET Id_Venda = EXCLUDED.Id_Venda, 
                    Id_Produto = EXCLUDED.Id_Produto,
                    Preco = EXCLUDED.Preco;";

                        foreach (var vendaCorpo in entidade.listaCorpo)
                        {
                            using (var cmd = new NpgsqlCommand(upsertVendaCorpoQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("IdVenda", vendaId);
                                cmd.Parameters.AddWithValue("Produto", vendaCorpo.id_produto);
                                cmd.Parameters.AddWithValue("Preco", vendaCorpo.preco);
                                cmd.Parameters.AddWithValue("Quantidade", vendaCorpo.quantidade);

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
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task Atualizar(Venda entidade)
        {
            NpgsqlConnection conn = null;
            NpgsqlTransaction transaction = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                transaction = conn.BeginTransaction();

                try
                {
                    var upsertVendaQuery = @"
            INSERT INTO Vendas (Id, Id_Cliente, Data_Criacao, Id_Usuario) 
            VALUES (@Id, @IdCliente, @DataCriacao, @IdUsuario)
            ON CONFLICT (Id) DO UPDATE
            SET Id_Cliente = EXCLUDED.Id_Cliente, 
                Data_Criacao = EXCLUDED.Data_Criacao,
                Id_Usuario = EXCLUDED.Id_Usuario
            RETURNING Id;";

                    int vendaId;
                    using (var cmd = new NpgsqlCommand(upsertVendaQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Id", entidade.id);
                        cmd.Parameters.AddWithValue("IdCliente", entidade.id_cliente);
                        cmd.Parameters.AddWithValue("DataCriacao", DateTime.Now);
                        cmd.Parameters.AddWithValue("IdUsuario", entidade.id_usuario);

                        vendaId = (int)await cmd.ExecuteScalarAsync();
                    }

                    var upsertVendaCorpoQuery = @"
            INSERT INTO VendasCorpo (Id, Id_Venda, Id_Produto, Preco, Quantidade) 
            VALUES (@Id, @IdVenda, @Produto, @Preco, @Quantidade)
            ON CONFLICT (Id) DO UPDATE
            SET Id_Venda = EXCLUDED.Id_Venda, 
                Id_Produto = EXCLUDED.Id_Produto,
                Preco = EXCLUDED.Preco,
                Quantidade = EXCLUDED.Quantidade;";

                    foreach (var vendaCorpo in entidade.listaCorpo)
                    {
                        using (var cmd = new NpgsqlCommand(upsertVendaCorpoQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("IdVenda", vendaId);
                            cmd.Parameters.AddWithValue("Produto", vendaCorpo.id_produto);
                            cmd.Parameters.AddWithValue("Preco", vendaCorpo.preco);
                            cmd.Parameters.AddWithValue("Quantidade", vendaCorpo.quantidade);

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
            finally
            {
                if (transaction != null)
                {
                    await transaction.DisposeAsync();
                }
                if (conn != null)
                {
                    await conn.CloseAsync();
                    await conn.DisposeAsync();
                }
            }
        }

        public async Task Deletar(Venda entidade)
        {
            NpgsqlConnection conn = null;
            NpgsqlTransaction transaction = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                transaction = conn.BeginTransaction();

                try
                {
                    var deleteVendaCorpoQuery = @"
            DELETE FROM VendasCorpo WHERE Id_Venda = @IdVenda;";

                    using (var cmd = new NpgsqlCommand(deleteVendaCorpoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("IdVenda", entidade.id);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    var deleteVendaQuery = @"
            DELETE FROM Vendas WHERE Id = @Id;";

                    using (var cmd = new NpgsqlCommand(deleteVendaQuery, conn))
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
            finally
            {
                if (transaction != null)
                {
                    await transaction.DisposeAsync();
                }
                if (conn != null)
                {
                    await conn.CloseAsync();
                    await conn.DisposeAsync();
                }
            }
        }


        public async Task GerarRelatorio(Venda venda)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Venda>> Listar()
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM Vendas", conn))
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
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task<Venda> ListarPorId(int id)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"SELECT * FROM Vendas WHERE Id = {id}", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    Venda venda = new Venda();
                    while (await reader.ReadAsync())
                        venda = venda.DbToEntidade(reader);

                    return venda;
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

        public async Task<List<VendaCorpo>> ListCorpoByID(int id)
        {
            NpgsqlConnection conn = null;
            try
            {
                conn = new NpgsqlConnection(_StringConnection);
                await conn.OpenAsync();

                using (var cmd = new NpgsqlCommand($"SELECT * FROM VendasCorpo WHERE Id_Venda = {id}", conn))
                {
                    var reader = await cmd.ExecuteReaderAsync();
                    List<VendaCorpo> vendaCorpos = new List<VendaCorpo>();
                    while (await reader.ReadAsync())
                    {
                        VendaCorpo vendaCorpo = new VendaCorpo();
                        vendaCorpos.Add(vendaCorpo.DbToEntidade(reader));
                    }
                    return vendaCorpos;
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
