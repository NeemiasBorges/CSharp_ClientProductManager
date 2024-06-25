using Dominio.Entidades;

namespace Aplicacao.DTO
{
    public class ContatoDTO
    {
        public ContatoDTO() { }
        public ContatoDTO(int id)
        {
            Id = id;
        }
        public ContatoDTO(string vlrContato)
        {
            this.vlrContato = vlrContato;
        }
        public ContatoDTO(int id, string vlrContato)
        {
            Id = id;
            this.vlrContato = vlrContato;
        }
        public int Id { get; set; }
        public string vlrContato { get; set; }

        public Contato ToContatoEntity()
        {
            return new Contato(Id, vlrContato);
        }
    }
}
