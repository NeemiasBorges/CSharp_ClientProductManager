namespace Aplicacao.Interface.Comum
{
    public interface IComumInterface<TEntidade>
    {
        void Inserir(TEntidade entidade);
        void Atualizar(TEntidade entidade);
        void Deletar(int id);
        List<TEntidade> Listar();
        TEntidade BuscarPorId(int id);
    }
}
