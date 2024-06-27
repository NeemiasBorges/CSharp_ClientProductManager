using Aplicacao.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;
using System;

namespace UnitTestes.AplicacaoTest
{
    [TestClass]
    public class ClienteDTOTests
    {
        [TestMethod]
        public void CriarClienteDTO_ComDadosValidos_DeveCriarClienteDTO()
        {
            var nome = "João Silva";
            var vlrEndereco = "Rua A, 123";
            var vlrTelefone = "123456789";
            var email = "joao.silva@example.com";

            var cliente = new ClienteDTO(nome, vlrEndereco, vlrTelefone, email);

            Assert.AreEqual(nome, cliente.Nome);
            Assert.AreEqual(vlrEndereco, cliente.vlrEndereco);
            Assert.AreEqual(vlrTelefone, cliente.vlrTelefone);
            Assert.AreEqual(email, cliente.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CriarClienteDTO_ComNomeNulo_DeveLancarArgumentNullException()
        {
            string nome = null;
            var vlrEndereco = "Rua A, 123";
            var vlrTelefone = "123456789";
            var email = "joao.silva@example.com";

            var cliente = new ClienteDTO(nome, vlrEndereco, vlrTelefone, email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CriarClienteDTO_ComEmailNulo_DeveLancarArgumentNullException()
        {
            var nome = "João Silva";
            var vlrEndereco = "Rua A, 123";
            var vlrTelefone = "123456789";
            string email = null;

            var cliente = new ClienteDTO(nome, vlrEndereco, vlrTelefone, email);
        }

     
    }
}
