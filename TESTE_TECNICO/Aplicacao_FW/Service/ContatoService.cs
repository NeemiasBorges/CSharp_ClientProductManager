using Aplicacao.DTO;
using Aplicacao.Interface;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacao.Service
{
    public class ContatoService : IContatoInterface
    {
        private readonly Repositorio.Interfaces.IInfraContatoInterface _contatoRepositorio;
        public ContatoService(string stringConnection)
        {
            _contatoRepositorio = new ContatoRepositorio(stringConnection);
        }
        public async Task Atualizar(ContatoDTO entidade)
        {
            try
            {
                await _contatoRepositorio.Atualizar(entidade.ToContatoEntity());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ContatoDTO> BuscarPorId(int id)
        {
            try
            {
                var contatoEntity = await _contatoRepositorio.ListarPorId(id);
                ContatoDTO contatoDto = new ContatoDTO() { vlrContato = contatoEntity.vlrContato, Id = contatoEntity.Id };
                return contatoDto;
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
                var contatoEntity = await _contatoRepositorio.ListarPorId(id);
                await _contatoRepositorio.Deletar(contatoEntity);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<int> Inserir(ContatoDTO entidade)
        {
            try
            {
                var id = await _contatoRepositorio.Adicionar(entidade.ToContatoEntity());
                return id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<ContatoDTO>> Listar()
        {
            try
            {
                var listaContato = await _contatoRepositorio.Listar();
                List<ContatoDTO> listaContatoDto = new List<ContatoDTO>();
                foreach (var contato in listaContato)
                {
                    listaContatoDto.Add(new ContatoDTO() { vlrContato = contato.vlrContato, Id = contato.Id });
                }
                return listaContatoDto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
