using Aplicacao.DTO;
using Aplicacao.Interface;
using Repositorio.Infra;
using Serilog;

namespace Aplicacao.Service
{
    public class VendaService : IVendaInterface
    {
        private readonly Repositorio.Interfaces.IInfraVendaInterface _vendaRepositorio;
        public VendaService(string stringConnection)
        {
            _vendaRepositorio = new VendaRepositorio(stringConnection);
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
                var venda       = await _vendaRepositorio.ListarPorId(id);
                var vendaHeader = new VendaDTO() { Id = venda.id, DataCriacao = venda.data_Criacao, IdCliente = venda.id_cliente };
                var vendaCorpo  = await _vendaRepositorio.ListCorpoByID(vendaHeader.Id);

                foreach (var item in vendaCorpo)
                    vendaHeader.VendaCorpo.Add(new VendaCorpoDTO() { IdHeader = item.id_header,  IdVenda = item.id_venda, IdProduto = item.id_produto, Quantidade = item.quantidade });

                return vendaHeader;
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw new Exception(e.Message);
            }
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

        public async Task GerarRelatorio(VendaDTO entidade)
        {
            try
            {
                await _vendaRepositorio.GerarRelatorio(entidade.ToVendaEntity());
            }
            catch (Exception)
            {
                Log.Error("Erro ao gerar o Relatório de Pedido de Vendas");
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
                List<VendaDTO> vendas = new();
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
