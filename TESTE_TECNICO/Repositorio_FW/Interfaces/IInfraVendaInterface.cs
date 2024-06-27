using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IInfraVendaInterface : IInfraCommumInterface<Venda>
    {
        Task GerarRelatorio(Venda venda);
        Task<List<VendaCorpo>> ListCorpoByID(int id);
    }
}
