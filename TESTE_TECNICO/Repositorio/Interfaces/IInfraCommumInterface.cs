namespace Repositorio.Interfaces
{
    public interface IInfraCommumInterface<TEntidade>
    {
        Task Adicionar(TEntidade entidade);
        Task Atualizar(TEntidade entidade);
        Task Deletar(TEntidade entidade);
        Task<List<TEntidade>> Listar();
        Task<TEntidade> ListarPorId(int id);
    }
}
