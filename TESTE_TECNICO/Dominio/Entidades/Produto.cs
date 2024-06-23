
using Npgsql;

namespace Dominio.Entidades
{
    public class Produto
    {
        public Produto(){}
        public Produto(int id, string nome, string descricao, float preco)
        {
            this.id = id;
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.preco = preco;
        }
        public Produto(string nome, string descricao, float preco)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            this.preco = preco;
        }

        public int    id         { get; private set; }
        public string nome       { get; private set; }
        public string descricao  { get; private set; }
        public float  preco      { get; private set; }

        public Produto DbToEntidade(NpgsqlDataReader reader)
        {
            return new Produto()
            {
                id = reader.GetInt32(0),
                nome = reader.GetString(1),
                descricao = reader.GetString(2),
                preco = reader.GetFloat(3),
            };
        }
    }
}
