using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;
using System;

namespace UnitTestes.DominioTest
{
    [TestClass]
    public class VendaTests
    {
        [TestMethod]
        public void CriarVenda_ComDadosValidos_DeveCriarVenda()
        {
            int id = 1;
            int id_cliente = 1;
            DateTime dataCriacao = DateTime.Now;
            int id_usuario = 1;

            var venda = new Dominio.Entidades.Venda(id, id_cliente, dataCriacao, id_usuario);

            Assert.AreEqual(id, venda.id);
            Assert.AreEqual(id_cliente, venda.id_cliente);
            Assert.AreEqual(dataCriacao, venda.data_Criacao);
            Assert.AreEqual(id_usuario, venda.id_usuario);
        }

        [TestMethod]
        public void CriarVenda_SemId_DeveCriarVenda()
        {
            int id_cliente = 1;
            DateTime dataCriacao = DateTime.Now;
            int id_usuario = 1;

            var venda = new Dominio.Entidades.Venda(id_cliente, dataCriacao, id_usuario);

            Assert.AreEqual(id_cliente, venda.id_cliente);
            Assert.AreEqual(dataCriacao, venda.data_Criacao);
            Assert.AreEqual(id_usuario, venda.id_usuario);
        }
    }

    [TestClass]
    public class VendaCorpoTests
    {
        [TestMethod]
        public void CriarVendaCorpo_ComDadosValidos_DeveCriarVendaCorpo()
        {
            int id_header = 1;
            int id_venda = 1;
            int id_produto = 1;
            int id_estoque = 1;
            double quantidade = 10.5;
            float preco = 100.0f;

            var vendaCorpo = new Dominio.Entidades.VendaCorpo(id_header, id_venda, id_produto, id_estoque, quantidade, preco);

            Assert.AreEqual(id_header, vendaCorpo.id_header);
            Assert.AreEqual(id_venda, vendaCorpo.id_venda);
            Assert.AreEqual(id_produto, vendaCorpo.id_produto);
            Assert.AreEqual(id_estoque, vendaCorpo.id_estoque);
            Assert.AreEqual(quantidade, vendaCorpo.quantidade);
            Assert.AreEqual(preco, vendaCorpo.preco);
        }

        [TestMethod]
        public void CriarVendaCorpo_SemIdHeader_DeveCriarVendaCorpo()
        {
            int id_produto = 1;
            double quantidade = 10.5;
            float preco = 100.0f;

            var vendaCorpo = new Dominio.Entidades.VendaCorpo(id_produto, quantidade, preco);

            Assert.AreEqual(0, vendaCorpo.id_header);
            Assert.AreEqual(id_produto, vendaCorpo.id_produto);
            Assert.AreEqual(quantidade, vendaCorpo.quantidade);
            Assert.AreEqual(preco, vendaCorpo.preco);
        }

      
    }
}
