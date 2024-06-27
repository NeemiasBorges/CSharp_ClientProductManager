using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IInfraContatoInterface
    {
        Task<int> Adicionar(Contato entidade);
        Task Atualizar(Contato entidade);
        Task Deletar(Contato entidade);
        Task<List<Contato>> Listar();
        Task<Contato> ListarPorId(int id);
    }
}
