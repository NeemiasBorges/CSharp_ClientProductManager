
namespace Dominio.Entidades
{
    public class Estoque
    {
        public Estoque(string nome, string descricao, float preco, double quantidade, int id_estoque, int quant_estoque)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.preco = preco;
            this.quantidade = quantidade;
            this.id_estoque = id_estoque;
            this.quant_estoque = quant_estoque;
        }

        public Estoque(int id, string nome, string descricao, float preco, double quantidade, int id_estoque, int quant_estoque)
        {
            this.id = id;
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.preco = preco;
            this.quantidade = quantidade;
            this.id_estoque = id_estoque;
            this.quant_estoque = quant_estoque;
        }

        public int    id             { get; private set; }
        public string nome           { get; private set; }
        public string descricao      { get; private set; }
        public float  preco          { get; private set; }
        public double quantidade     { get; private set; }
        public int    id_estoque     { get; private set; }
        public int    quant_estoque  { get; private set; }
    }
}
