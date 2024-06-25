namespace Aplicacao.Interface.Comum
{
    public interface IComumInterface<TEntidade>
    {
        Task Inserir(TEntidade entidade);
        Task Atualizar(TEntidade entidade);
        Task Deletar(int id);
        Task<List<TEntidade>> Listar();
        Task<TEntidade> BuscarPorId(int id);
    }
}
