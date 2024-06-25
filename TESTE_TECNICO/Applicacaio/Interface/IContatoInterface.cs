using Aplicacao.DTO;
using Aplicacao.Interface.Comum;

namespace Aplicacao.Interface
{
    public interface IContatoInterface 
    {
        Task<int> Inserir(ContatoDTO entidade);
        Task Atualizar(ContatoDTO entidade);
        Task Deletar(int id);
        Task<List<ContatoDTO>> Listar();
        Task<ContatoDTO> BuscarPorId(int id);
    }
}
