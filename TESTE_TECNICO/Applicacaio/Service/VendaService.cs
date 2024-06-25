using Aplicacao.DTO;
using Aplicacao.Interface;
using Dominio.Entidades;
using Repositorio.Infra;
using System.Collections.Generic;

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
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<VendaDTO> BuscarPorId(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Deletar(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
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
                throw new Exception(e.Message);
            }
        }
    }
}
