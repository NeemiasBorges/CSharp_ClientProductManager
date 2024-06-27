using Dominio.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao.DTO
{
    public class VendaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "A data de criação da venda é obrigatória.")]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int IdUsuario { get; set; }

        public List<VendaCorpoDTO> VendaCorpo { get; set; } = new List<VendaCorpoDTO>();
        public string Fornecedor { get; set; }

        public VendaDTO() { }

        public VendaDTO(int id, int idCliente, DateTime dataCriacao, int idUsuario)
        {
            Id = id;
            IdCliente = idCliente;
            DataCriacao = dataCriacao;
            IdUsuario = idUsuario;
        }

        public VendaDTO(int id, int idCliente, DateTime dataCriacao, int idUsuario, string fornecedor)
        {
            Id = id;
            IdCliente = idCliente;
            DataCriacao = dataCriacao;
            IdUsuario = idUsuario;
            Fornecedor = fornecedor;
        }

        public VendaDTO(NpgsqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            IdCliente = reader.GetInt32(1);
            DataCriacao = reader.GetDateTime(2);
            IdUsuario = reader.GetInt32(3);
        }

        public Venda ToVendaEntity()
        {
            if (VendaCorpo == null)
            {
                throw new InvalidOperationException("Corpo do pedido de venda não pode ser nulo.");
            }

            var vendaEntity = new Venda(Id, IdCliente, DataCriacao, IdUsuario);

            foreach (var itmvendacorpo in VendaCorpo)
            {
                vendaEntity.listaCorpo.Add(itmvendacorpo.ToVendaCorpoEntity(itmvendacorpo));
            }

            return vendaEntity;
        }
    }
}
