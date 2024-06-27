using Aplicacao.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

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
