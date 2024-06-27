using Aplicacao.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;
using System;

namespace UnitTestes.AplicacaoTest
{
    [TestClass]
    public class ProdutoDTOTests
    {
        [TestMethod]
        public void CriarProdutoDTO_SemParametros_DeveCriarProdutoDTO()
        {
            var produto = new ProdutoDTO();

            Assert.AreEqual(0, produto.Id);
            Assert.AreEqual("", produto.Nome);
            Assert.AreEqual("", produto.Descricao);
            Assert.AreEqual(0, produto.Preco);
        }

        [TestMethod]
        public void CriarProdutoDTO_ComNomeDescricaoPreco_DeveCriarProdutoDTO()
        {
            var nome = "Produto A";
            var descricao = "Descrição do Produto A";
            var preco = 9.99f;

            var produto = new ProdutoDTO(nome, descricao, preco);

            Assert.AreEqual(nome, produto.Nome);
            Assert.AreEqual(descricao, produto.Descricao);
            Assert.AreEqual(preco, produto.Preco);
        }

        [TestMethod]
        public void CriarProdutoDTO_ComIdNomeDescricaoPreco_DeveCriarProdutoDTO()
        {
            var id = 1;
            var nome = "Produto A";
            var descricao = "Descrição do Produto A";
            var preco = 9.99f;

            var produto = new ProdutoDTO(id, nome, descricao, preco);

            Assert.AreEqual(id, produto.Id);
            Assert.AreEqual(nome, produto.Nome);
            Assert.AreEqual(descricao, produto.Descricao);
            Assert.AreEqual(preco, produto.Preco);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CriarProdutoDTO_ComNomeNulo_DeveLancarArgumentNullException()
        {
            string nome = null;
            var descricao = "Descrição do Produto A";
            var preco = 9.99f;

            var produto = new ProdutoDTO(nome, descricao, preco);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CriarProdutoDTO_ComDescricaoNula_DeveLancarArgumentNullException()
        {
            var nome = "Produto A";
            string descricao = null;
            var preco = 9.99f;

            var produto = new ProdutoDTO(nome, descricao, preco);
        }
    }
}
