using Aplicacao.DTO;

namespace Aplicacao.Interface
{
    public interface IEnderecoInterface 
    {
        Task<int> Inserir(EnderecoDTO entidade);
        Task Atualizar(EnderecoDTO entidade);
        Task Deletar(int id);
        Task<List<EnderecoDTO>> Listar();
        Task<EnderecoDTO> BuscarPorId(int id);
    }
}
