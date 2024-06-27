using Dominio.Entidades;
using Npgsql;
using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; } = 0;

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        public string Descricao { get; set; } = "";

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Range(0.01, 999999, ErrorMessage = "O preço do produto deve estar entre 0.01 e 999999.")]
        public float Preco { get; set; } = 0;

        public ProdutoDTO() { }

        public ProdutoDTO(string nome, string descricao, float preco)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Preco = preco;
        }
        
        public ProdutoDTO(int id, string nome, string descricao, float preco)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Preco = preco;
        }

        public ProdutoDTO(NpgsqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            Nome = reader.GetString(1);
            Descricao = reader.GetString(2);
            Preco = reader.GetFloat(3);
        }

        public Produto ToProdutoEntity()
        {
            return new Produto(Id, Nome, Descricao, Preco);
        }
    }
}
