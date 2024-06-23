
using Npgsql;
using System.Data;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public Cliente(){}

        public Cliente(int id, string nome, int id_endereco, int id_telefone, string email)
        {
            this.id = id;
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.id_endereco = id_endereco;
            this.id_telefone = id_telefone;
            this.email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Cliente(string nome, int id_endereco, int id_telefone, string email)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.id_endereco = id_endereco;
            this.id_telefone = id_telefone;
            this.email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public int    id           { get; private set; }
        public string nome         { get; private set; }
        public int    id_endereco  { get; private set; }
        public int    id_telefone  { get; private set; }
        public string email        { get; private set; }

        public Cliente DbToEntidade(NpgsqlDataReader reader)
        {
            return new Cliente()
            {
                id          = reader.GetInt32(0),
                nome        = reader.GetString(1),
                id_endereco = reader.GetInt32(2),
                id_telefone = reader.GetInt32(3),
                email       = reader.GetString(4)
            };
        }
    }
}
