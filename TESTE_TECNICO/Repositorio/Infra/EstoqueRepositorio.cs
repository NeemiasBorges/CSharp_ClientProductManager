using Dominio.Entidades;
using Microsoft.Extensions.Configuration;
using Repositorio.Interfaces;

namespace Repositorio.Infra
{
    public class EstoqueRepositorio : IEstoqueInterface
    {
        private string _connectionString = "";
        public EstoqueRepositorio(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task Adicionar(Estoque entidade)
        {
            throw new NotImplementedException();
        }

        public async Task Atualizar(Estoque entidade)
        {
            throw new NotImplementedException();
        }

        public async Task Deletar(Estoque entidade)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Estoque>> Listar()
        {
            throw new NotImplementedException();
        }

        public async Task<Estoque> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
