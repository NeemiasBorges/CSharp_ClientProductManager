namespace Dominio.Entidades
{
    public class VendaCorpo
    {
       public VendaCorpo() { }

        public VendaCorpo(int id_header, int id_venda, int id_produto, int id_estoque, double quantidade, float preco)
        {
            this.id_header = id_header;
            this.id_venda = id_venda;
            this.id_produto = id_produto;
            this.id_estoque = id_estoque;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public int    id_header  { get; private set; }
        public int    id_venda   { get; private set; }
        public int    id_produto { get; private set; }
        public int    id_estoque { get; private set; }
        public double quantidade { get; private set; }
        public float  preco      { get; private set; }
    }
}
