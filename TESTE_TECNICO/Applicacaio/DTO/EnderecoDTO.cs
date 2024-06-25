using Dominio.Entidades;

namespace Aplicacao.DTO
{
    public class EnderecoDTO
    {
        public EnderecoDTO(){}
        public EnderecoDTO(int id)
        {
            Id = id;
        }
        public EnderecoDTO(string vlrEndereco)
        {
            this.vlrEndereco = vlrEndereco;
        }
        public EnderecoDTO(int id, string vlrEndereco)
        {
            Id = id;
            this.vlrEndereco = vlrEndereco;
        }
        public int Id { get; set; } 
        public string vlrEndereco { get; set; }

        public Endereco ToEnderecoEntity()
        {
            return new Endereco(Id, vlrEndereco);
        }
    }
}
