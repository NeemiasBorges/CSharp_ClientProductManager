using Dominio.Entidades;
using Npgsql;
using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Nome { get; set; }
        public string vlrEndereco { get; set; }
        public int IdEndereco { get; set; }
        public string vlrTelefone { get; set; }
        public int IdTelefone { get; set; }

        [Required(ErrorMessage = "O email do cliente é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email fornecido não é válido.")]
        public string Email { get; set; }

        public ClienteDTO() { }

        public ClienteDTO(string nome, string vlrendereco, string vlrtelefone, string email)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            vlrEndereco = vlrendereco ?? throw new ArgumentNullException(nameof(vlrendereco));
            vlrTelefone = vlrtelefone ?? throw new ArgumentNullException(nameof(vlrtelefone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
        
        public ClienteDTO(string nome, int idEndereco, int idTelefone, string email)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            IdEndereco = idEndereco;
            IdTelefone = idTelefone;
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
        public ClienteDTO(int id, string nome, int idEndereco, int idTelefone, string email)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            IdEndereco = idEndereco;
            IdTelefone = idTelefone;
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public ClienteDTO(NpgsqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            Nome = reader.GetString(1);
            IdEndereco = reader.GetInt32(2);
            IdTelefone = reader.GetInt32(3);
            Email = reader.GetString(4);
        }

        public Contato ToContatoEntity(ClienteDTO entidade)
        {
            return new Contato(entidade.vlrTelefone);
        }

        public Endereco ToEnderecoEntity(ClienteDTO entidade)
        {
            return new Endereco(entidade.vlrEndereco);
        }

        public Cliente ToClienteEntity()
        {
            return new Cliente(Nome, IdEndereco, IdTelefone, Email);
        }
    }
}
