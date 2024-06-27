using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestes.DominioTest
{
    [TestClass]
    public class ContatoTests
    {
        [TestMethod]
        public void CriarContato_ComContatoValido_DeveCriarContato()
        {
            string contato = "123456789";
            var contatoObj = new Dominio.Entidades.Contato(contato);

            Assert.AreEqual(contato, contatoObj.vlrContato);
        }

        [TestMethod]
        public void CriarContato_ComId_DeveCriarContato()
        {
            int id = 1;

            var contatoObj = new Dominio.Entidades.Contato(id);
            Assert.AreEqual(id, contatoObj.Id);
        }

        [TestMethod]
        public void CriarContato_ComIdEContato_DeveCriarContato()
        {
            int id = 1;
            string contato = "contato@teste.com";
            var contatoObj = new Dominio.Entidades.Contato(id, contato);

            Assert.AreEqual(id, contatoObj.Id);
            Assert.AreEqual(contato, contatoObj.vlrContato);
        }
    }
}
