
using Npgsql;

namespace Dominio.Entidades
{
    public class Contato
    {
        public Contato(){}

        public Contato(string contato)
        {
            vlrContato = contato ?? throw new ArgumentNullException(nameof(contato));
        }
        
        public Contato(int contato_id)
        {
            Id = contato_id;
        }
        
        public Contato(int id, string contato)
        {
            Id = id;
            vlrContato = contato ?? throw new ArgumentNullException(nameof(contato));
        }

        public Contato DbToEntidade(NpgsqlDataReader reader)
        {
            return new Contato()
            {
                Id = reader.GetInt32(0),
                vlrContato = reader.GetString(1),
            };
        }

        public int Id { get; private set; }
        public string vlrContato { get; private set; }
    }
}
