using Dominio.Entidades;

namespace Repositorio.Interfaces
{
    public interface IInfraVendaInterface : IInfraCommumInterface<Venda>
    {
        Task GerarRelatorio(Venda venda);
        Task<List<VendaCorpo>> ListCorpoByID(int id);
    }
}
