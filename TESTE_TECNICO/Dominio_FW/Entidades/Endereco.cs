
using Npgsql;
using System;

namespace Dominio.Entidades
{
    public class Endereco
    {
        public Endereco(){}
        public Endereco(string vlrEndereco)
        {
            this.vlrEndereco = vlrEndereco ?? throw new ArgumentNullException(nameof(vlrEndereco));
        }
        
        public Endereco(int id)
        {
            Id = id;
        }
        
        public Endereco(int id, string vlrEndereco)
        {
            Id = id;
            this.vlrEndereco = vlrEndereco ?? throw new ArgumentNullException(nameof(vlrEndereco));
        }

        virtual public Endereco DbToEntidade(NpgsqlDataReader reader)
        {
            return new Endereco()
            {
                Id = reader.GetInt32(0),
                vlrEndereco = reader.GetString(1),
            };
        }   

        public int Id { get; private set; }
        public string vlrEndereco { get; private set; }
    }
}
