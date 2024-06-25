using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface IInfraEnderecoInterface 
    {
        Task<int> Adicionar(Endereco entidade);
        Task Atualizar(Endereco entidade);
        Task Deletar(Endereco entidade);
        Task<List<Endereco>> Listar();
        Task<Endereco> ListarPorId(int id);
    }
}
