using Aplicacao.DTO;
using Aplicacao.Interface.Comum;
using Dominio.Entidades;

namespace Aplicacao.Interface
{
    public interface IClienteInterface : IComumInterface<ClienteDTO>
    {
        Task<string> ObterTelefone(int idTelefone);
        Task<string> ObterEndereco(int idEndereco);
        Task<ClienteDTO> CriarClienteDto(Cliente cliente, string telefone, string endereco);


    }
}
