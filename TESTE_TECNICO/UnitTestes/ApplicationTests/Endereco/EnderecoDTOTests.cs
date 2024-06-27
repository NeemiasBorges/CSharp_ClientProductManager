using Aplicacao.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestes.AplicacaoTest
{
    [TestClass]
    public class EnderecoDTOTests
    {
        [TestMethod]
        public void CriarEnderecoDTO_SemParametros_DeveCriarEnderecoDTO()
        {
            var endereco = new EnderecoDTO();

            Assert.AreEqual(0, endereco.Id);
            Assert.IsNull(endereco.vlrEndereco);
        }

        [TestMethod]
        public void CriarEnderecoDTO_ComId_DeveCriarEnderecoDTOComId()
        {
            var id = 1;
            var endereco = new EnderecoDTO(id);

            Assert.AreEqual(id, endereco.Id);
            Assert.IsNull(endereco.vlrEndereco);
        }

        [TestMethod]
        public void CriarEnderecoDTO_ComVlrEndereco_DeveCriarEnderecoDTOComVlrEndereco()
        {
            var vlrEndereco = "Rua A, 123";
            var endereco = new EnderecoDTO(vlrEndereco);

            Assert.AreEqual(0, endereco.Id);
            Assert.AreEqual(vlrEndereco, endereco.vlrEndereco);
        }

        [TestMethod]
        public void CriarEnderecoDTO_ComIdEVlrEndereco_DeveCriarEnderecoDTOComIdEVlrEndereco()
        {
            var id = 1;
            var vlrEndereco = "Rua A, 123";
            var endereco = new EnderecoDTO(id, vlrEndereco);

            Assert.AreEqual(id, endereco.Id);
            Assert.AreEqual(vlrEndereco, endereco.vlrEndereco);
        }
    }
}
