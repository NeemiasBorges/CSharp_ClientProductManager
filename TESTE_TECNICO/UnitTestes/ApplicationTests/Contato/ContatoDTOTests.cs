using Aplicacao.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestes.AplicacaoTest
{
    [TestClass]
    public class ContatoDTOTests
    {
        [TestMethod]
        public void CriarContatoDTO_SemParametros_DeveCriarContatoDTO()
        {
            var contato = new ContatoDTO();

            Assert.AreEqual(0, contato.Id);
            Assert.IsNull(contato.vlrContato);
        }

        [TestMethod]
        public void CriarContatoDTO_ComId_DeveCriarContatoDTOComId()
        {
            var id = 1;
            var contato = new ContatoDTO(id);

            Assert.AreEqual(id, contato.Id);
            Assert.IsNull(contato.vlrContato);
        }

        [TestMethod]
        public void CriarContatoDTO_ComVlrContato_DeveCriarContatoDTOComVlrContato()
        {
            var vlrContato = "123456789";
            var contato = new ContatoDTO(vlrContato);

            Assert.AreEqual(0, contato.Id);
            Assert.AreEqual(vlrContato, contato.vlrContato);
        }

        [TestMethod]
        public void CriarContatoDTO_ComIdEVlrContato_DeveCriarContatoDTOComIdEVlrContato()
        {
            var id = 1;
            var vlrContato = "123456789";
            var contato = new ContatoDTO(id, vlrContato);

            Assert.AreEqual(id, contato.Id);
            Assert.AreEqual(vlrContato, contato.vlrContato);
        }
    }
}
