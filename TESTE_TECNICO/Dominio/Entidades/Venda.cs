using Npgsql;

namespace Dominio.Entidades
{
    public class Venda
    {
        public Venda(){}

        public Venda(int id, int id_cliente, DateTime data_Criacao, int id_usuario)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.data_Criacao = data_Criacao;
            this.id_usuario = id_usuario;
        }

        public Venda(int id_cliente, DateTime data_Criacao, int id_usuario)
        {
            this.id_cliente = id_cliente;
            this.data_Criacao = data_Criacao;
            this.id_usuario = id_usuario;
        }

        public int       id                { get; private set; }
        public DateTime  data_Criacao      { get; private set; }
        public int       id_usuario        { get; private set; }
        public int       id_cliente        { get; private set; }
        public List<VendaCorpo> listaCorpo { get; private set; }

        public Venda DbToEntidade(NpgsqlDataReader reader)
        {
            return new Venda()
            {
                id = reader.GetInt32(0),
                id_cliente = reader.GetInt32(1),
                data_Criacao = reader.GetDateTime(2),
                id_usuario = reader.GetInt32(3)
            };
        }
    }
}
