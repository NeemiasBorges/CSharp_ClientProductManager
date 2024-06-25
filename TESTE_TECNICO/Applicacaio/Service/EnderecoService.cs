using Aplicacao.DTO;
using Aplicacao.Interface;
using Repositorio.Infra;

namespace Aplicacao.Service
{
    public class EnderecoService : IEnderecoInterface
    {
        private readonly Repositorio.Interfaces.IInfraEnderecoInterface _enredecoInterface;
        public EnderecoService(string stringConnection)
        {
            _enredecoInterface = new EnderecoRepositorio(stringConnection);
        }
        public async Task Atualizar(EnderecoDTO entidade)
        {
            try
            {
                await _enredecoInterface.Atualizar(entidade.ToEnderecoEntity());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<EnderecoDTO> BuscarPorId(int id)
        {
            try
            {
                var enderecoEntity = await _enredecoInterface.ListarPorId(id);
                EnderecoDTO enderecoDto = new EnderecoDTO() { vlrEndereco = enderecoEntity.vlrEndereco, Id = enderecoEntity.Id };
                return enderecoDto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Deletar(int id)
        {
            try
            {
                var enderecoEntity = await _enredecoInterface.ListarPorId(id);
                await _enredecoInterface.Deletar(enderecoEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<int> Inserir(EnderecoDTO entidade)
        {
            try
            {
                var id = await _enredecoInterface.Adicionar(entidade.ToEnderecoEntity());
                return id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<EnderecoDTO>> Listar()
        {
            try
            {
                var listaEndereco = await _enredecoInterface.Listar();
                List<EnderecoDTO> listaEnderecoDto = new List<EnderecoDTO>();
                foreach (var item in listaEndereco)
                {
                    listaEnderecoDto.Add(new EnderecoDTO() { vlrEndereco = item.vlrEndereco, Id = item.Id });
                }
                return listaEnderecoDto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
