using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Npgsql;

namespace UnitTestes.DominioTest
{
    [TestClass]
    public class DominioTest
    {
        [TestMethod]
        public void CriarEndereco_ComEnderecoValido_DeveCriarEndereco()
        {
            string vlrEndereco = "Rua Teste, 123";
            var enderecoObj = new Dominio.Entidades.Endereco(vlrEndereco);

            Assert.AreEqual(vlrEndereco, enderecoObj.vlrEndereco);
        }

        [TestMethod]
        public void CriarEndereco_ComId_DeveCriarEndereco()
        {
            int id = 1;
            var enderecoObj = new Dominio.Entidades.Endereco(id);

            Assert.AreEqual(id, enderecoObj.Id);
        }

        [TestMethod]
        public void CriarEndereco_ComIdEEndereco_DeveCriarEndereco()
        {
            int id = 1;
            string vlrEndereco = "Rua Teste, 123";

            var enderecoObj = new Dominio.Entidades.Endereco(id, vlrEndereco);
            Assert.AreEqual(id, enderecoObj.Id);
            Assert.AreEqual(vlrEndereco, enderecoObj.vlrEndereco);
        }
    }
}
