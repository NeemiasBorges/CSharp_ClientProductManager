namespace Aplicacao.Interface.Comum
{
    public interface IRelatorioInterface<TEntity>
    {
        void GerarRelatorio(TEntity entidade);
    }
}
