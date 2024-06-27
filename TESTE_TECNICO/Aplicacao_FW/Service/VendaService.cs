using Aplicacao.DTO;
using Aplicacao.Interface;
using Dominio.Entidades;
using Repositorio.Infra;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacao.Service
{
    public class VendaService : IVendaInterface
    {
        private readonly Repositorio.Interfaces.IInfraVendaInterface _vendaRepositorio;
        private readonly Repositorio.Interfaces.IInfraClienteInterface _clienteRepositorio;
        private readonly Repositorio.Interfaces.IInfraProdutoInterface _produtoRepositorio;
        public VendaService(string stringConnection)
        {
            _vendaRepositorio = new VendaRepositorio(stringConnection);
            _clienteRepositorio = new ClienteRepositorio(stringConnection);
            _produtoRepositorio = new ProdutoRepositorio(stringConnection);
        }
        public async Task Atualizar(VendaDTO entidade)
        {
            try
            {
                await _vendaRepositorio.Atualizar(entidade.ToVendaEntity());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message);
            }
        }

        public async Task<VendaDTO> BuscarPorId(int id)
        {
            try
            {
                var venda = await _vendaRepositorio.ListarPorId(id);
                var cliente = await _clienteRepositorio.ListarPorId(venda.id_cliente);
                var vendaHeader = MapearVendaParaDTO(venda, cliente);
                var vendaCorpo = await _vendaRepositorio.ListCorpoByID(vendaHeader.Id);

                foreach (var item in vendaCorpo)
                {
                    var produto = await _produtoRepositorio.ListarPorId(item.id_produto);
                    vendaHeader.VendaCorpo.Add(MapearVendaCorpoParaDTO(item, produto));
                }

                return vendaHeader;
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message, e);
            }
        }

        private VendaDTO MapearVendaParaDTO(Venda venda, Cliente cliente)
        {
            return new VendaDTO
            {
                Id = venda.id,
                DataCriacao = venda.data_Criacao,
                IdCliente = venda.id_cliente,
                Fornecedor = cliente.nome,
                VendaCorpo = new List<VendaCorpoDTO>()
            };
        }

        private VendaCorpoDTO MapearVendaCorpoParaDTO(VendaCorpo item, Produto produto)
        {
            return new VendaCorpoDTO
            {
                IdHeader = item.id_header,
                IdVenda = item.id_venda,
                IdProduto = item.id_produto,
                Quantidade = item.quantidade,
                Preco = item.preco,
                Descricao = produto.descricao
            };
        }

        public async Task Deletar(int id)
        {
            try
            {
                var pedidoVenda = await _vendaRepositorio.ListarPorId(id);
                await _vendaRepositorio.Deletar(pedidoVenda);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message);
            }
        }

        public async Task Inserir(VendaDTO entidade)
        {
            try
            {
                await _vendaRepositorio.Adicionar(entidade.ToVendaEntity());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message);
            }
        }

        public async Task<List<VendaDTO>> Listar()
        {
            try
            {
                List<VendaDTO> vendas = new List<VendaDTO>();
                var vendasEntity = await _vendaRepositorio.Listar();

                foreach (var venda in vendasEntity)
                    vendas.Add(new VendaDTO() { Id = venda.id, DataCriacao = venda.data_Criacao, IdCliente = venda.id_cliente });

                return vendas;
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message);
            }
        }
    }
}
