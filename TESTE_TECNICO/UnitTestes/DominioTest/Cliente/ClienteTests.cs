using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestes.DominioTest
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void CriarCliente_ComDadosValidos_DeveCriarCliente()
        {
            var id = 1;
            var nome = "Neemias";
            var id_endereco = 2;
            var id_telefone = 1;
            var email = "neemiasb.dev@gmail.com";

            var cliente = new Dominio.Entidades.Cliente(id, nome, id_endereco, id_telefone, email);

            Assert.AreEqual(id, cliente.id);
            Assert.AreEqual(nome, cliente.nome);
            Assert.AreEqual(id_endereco, cliente.id_endereco);
            Assert.AreEqual(id_telefone, cliente.id_telefone);
            Assert.AreEqual(email, cliente.email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CriarCliente_ComNomeNulo_DeveLancarArgumentNullException()
        {
            string nome = null;
            var id_endereco = 12;
            var id_telefone = 3;
            var email = "test@teste.com";

            var cliente = new Dominio.Entidades.Cliente(nome, id_endereco, id_telefone, email);
        }
    }
}
