using Aplicacao.DTO;
using Aplicacao.Interface;
using Dominio.Entidades;
using Repositorio.Infra;

namespace Aplicacao.Service
{
    public class ClienteService : IClienteInterface
    {
        private readonly Repositorio.Interfaces.IInfraClienteInterface _clienteRepositorio;
        private readonly Repositorio.Interfaces.IInfraEnderecoInterface _enderecoRepositorio;
        private readonly Repositorio.Interfaces.IInfraContatoInterface _contatoRepositorio;
        public ClienteService(string stringConnection)
        {
            _clienteRepositorio = new ClienteRepositorio(stringConnection);
            _enderecoRepositorio = new EnderecoRepositorio(stringConnection);
            _contatoRepositorio = new ContatoRepositorio(stringConnection);
        }
        public async Task Atualizar(ClienteDTO entidade)
        {
            try
            {
                await _clienteRepositorio.Atualizar(entidade.ToClienteEntity());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ClienteDTO> BuscarPorId(int id)
        {
            try
            {
                var cliEntity = await _clienteRepositorio.ListarPorId(id);
                var telefone = await ObterTelefone(cliEntity.id_telefone);
                var endereco = await ObterEndereco(cliEntity.id_endereco);

                var clienteDto = await CriarClienteDto(cliEntity, telefone, endereco);
                return clienteDto;
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
                var cliEntity = await _clienteRepositorio.ListarPorId(id);
                await _enderecoRepositorio.Deletar(cliEntity.ToEnderecoEntity(cliEntity));
                await _contatoRepositorio.Deletar(cliEntity.ToContatoEntity(cliEntity));
                await _clienteRepositorio.Deletar(cliEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task GerarRelatorio(ClienteDTO entidade)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Inserir(ClienteDTO entidade)
        {
            try
            {
                entidade.IdTelefone = await _contatoRepositorio.Adicionar(entidade.ToContatoEntity(entidade));
                entidade.IdEndereco = await _enderecoRepositorio.Adicionar(entidade.ToEnderecoEntity(entidade));

                await _clienteRepositorio.Adicionar(entidade.ToClienteEntity());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<ClienteDTO>> Listar()
        {
            try
            {
                var clientes = await _clienteRepositorio.Listar();
                var clienteDtos = new List<ClienteDTO>();

                foreach (var cliente in clientes)
                {
                    var telefone = await ObterTelefone(cliente.id_telefone);
                    var endereco = await ObterEndereco(cliente.id_endereco);

                    var clienteDto = await CriarClienteDto(cliente, telefone, endereco);
                    clienteDtos.Add(clienteDto);
                }

                return clienteDtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar clientes", ex);
            }
        }

        public async Task<string> ObterTelefone(int idTelefone)
        {
            var contato = await _contatoRepositorio.ListarPorId(idTelefone);
            return contato.vlrContato;
        }

        public async Task<string> ObterEndereco(int idEndereco)
        {
            var endereco = await _enderecoRepositorio.ListarPorId(idEndereco);
            return endereco.vlrEndereco;
        }

        public async Task<ClienteDTO> CriarClienteDto(Cliente cliente, string telefone, string endereco)
        {
            return new ClienteDTO
            {
                Id = cliente.id,
                Nome = cliente.nome,
                Email = cliente.email,
                vlrTelefone = telefone,
                vlrEndereco = endereco
            };
        }
    }
}
