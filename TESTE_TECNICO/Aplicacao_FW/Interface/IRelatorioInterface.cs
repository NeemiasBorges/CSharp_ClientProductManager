using System.Threading.Tasks;

namespace Aplicacao.Interface
{
    public interface IRelatorioInterface<TEntity>
    {
        Task GerarRelatorio(TEntity entidade);
    }
}
