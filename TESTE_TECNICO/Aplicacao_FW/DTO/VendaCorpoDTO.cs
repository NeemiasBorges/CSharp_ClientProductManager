using Dominio.Entidades;

namespace Aplicacao.DTO
{
    public class VendaCorpoDTO
    {
        public int IdHeader      { get; set; }
        public int IdVenda       { get; set; }
        public int IdProduto     { get; set; }
        public int IdEstoque     { get; set; }
        public double Quantidade { get; set; }
        public float Preco       { get; set; }
        public string Descricao { get; set; }

        public VendaCorpoDTO() { }

        public VendaCorpoDTO(int idHeader, int idVenda, int idProduto, int idEstoque, double quantidade, float preco)
        {
            IdHeader = idHeader;
            IdVenda = idVenda;
            IdProduto = idProduto;
            IdEstoque = idEstoque;
            Quantidade = quantidade;
            Preco = preco;
        }
        
        public VendaCorpo ToVendaCorpoEntity(VendaCorpoDTO vendaCorpoDto)
        {
            return new VendaCorpo(vendaCorpoDto.IdProduto, vendaCorpoDto.Quantidade, vendaCorpoDto.Preco);
        }
    }
}
