using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;

namespace UnitTestes.DominioTest
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void CriarProduto_ComDadosValidos_DeveCriarProduto()
        {
            int id = 1;
            string nome = "Produto Teste";
            string descricao = "Descrição do Produto";
            float preco = 100.50f;

            var produto = new Dominio.Entidades.Produto(id, nome, descricao, preco);

            Assert.AreEqual(id, produto.id);
            Assert.AreEqual(nome, produto.nome);
            Assert.AreEqual(descricao, produto.descricao);
            Assert.AreEqual(preco, produto.preco);
        }

        [TestMethod]
        public void CriarProduto_SemId_DeveCriarProduto()
        {
            string nome = "Produto Teste";
            string descricao = "Descrição do Produto";
            float preco = 100.50f;

            var produto = new Dominio.Entidades.Produto(nome, descricao, preco);

            Assert.AreEqual(nome, produto.nome);
            Assert.AreEqual(descricao, produto.descricao);
            Assert.AreEqual(preco, produto.preco);
        }
    }
}
