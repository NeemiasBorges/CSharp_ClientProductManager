using Aplicacao.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;
using System;

namespace UnitTestes.AplicacaoTest
{
    [TestClass]
    public class VendaDTOTests
    {
        [TestMethod]
        public void CriarVendaDTO_SemParametros_DeveCriarVendaDTO()
        {
            var venda = new VendaDTO();

            Assert.AreEqual(0, venda.Id);
            Assert.AreEqual(0, venda.IdCliente);
            Assert.AreEqual(DateTime.MinValue, venda.DataCriacao);
            Assert.AreEqual(0, venda.IdUsuario);
            Assert.AreEqual(0, venda.VendaCorpo.Count);
            Assert.IsNull(venda.Fornecedor);
        }

        [TestMethod]
        public void CriarVendaDTO_ComParametros_DeveCriarVendaDTO()
        {
            var id = 1;
            var idCliente = 2;
            var dataCriacao = DateTime.Now;
            var idUsuario = 3;
            var venda = new VendaDTO(id, idCliente, dataCriacao, idUsuario);

            Assert.AreEqual(id, venda.Id);
            Assert.AreEqual(idCliente, venda.IdCliente);
            Assert.AreEqual(dataCriacao, venda.DataCriacao);
            Assert.AreEqual(idUsuario, venda.IdUsuario);
        }

        [TestMethod]
        public void CriarVendaDTO_ComParametrosEFornecedor_DeveCriarVendaDTO()
        {
            var id = 1;
            var idCliente = 2;
            var dataCriacao = DateTime.Now;
            var idUsuario = 3;
            var fornecedor = "Fornecedor X";
            var venda = new VendaDTO(id, idCliente, dataCriacao, idUsuario, fornecedor);

            Assert.AreEqual(id, venda.Id);
            Assert.AreEqual(idCliente, venda.IdCliente);
            Assert.AreEqual(dataCriacao, venda.DataCriacao);
            Assert.AreEqual(idUsuario, venda.IdUsuario);
            Assert.AreEqual(fornecedor, venda.Fornecedor);
        }
    }
}
