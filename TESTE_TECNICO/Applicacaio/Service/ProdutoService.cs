using Aplicacao.DTO;
using Aplicacao.Interface;
using Repositorio.Infra;
using Serilog;

namespace Aplicacao.Service
{
    public class ProdutoService : IProdutoInterface
    {
        private readonly Repositorio.Interfaces.IInfraProdutoInterface _produtoInterface;
        public ProdutoService(string stringConnection)
        {
            _produtoInterface = new ProdutoRepositorio(stringConnection);
        }
        public async Task Atualizar(ProdutoDTO entidade)
        {
            try
            {
                await _produtoInterface.Atualizar(entidade.ToProdutoEntity());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }

        public async Task<ProdutoDTO> BuscarPorId(int id)
        {
            ProdutoDTO produtoDTO = new();
            try
            {
                var prod = await _produtoInterface.ListarPorId(id);

                if (prod == null)
                    throw new Exception($"Produto {id} não encontrado");

                produtoDTO = new ProdutoDTO() { Id = prod.id, Descricao = prod.descricao, Preco = prod.preco, Nome = prod.nome };

                return produtoDTO;
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }

            return produtoDTO;
        }

        public async Task Deletar(int id)
        {
            try
            {
                var prod = await _produtoInterface.ListarPorId(id);

                if (prod == null)
                    throw new Exception($"Produto {id} não encontrado");

                await _produtoInterface.Deletar(prod);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }

        public async Task Inserir(ProdutoDTO entidade)
        {
            try
            {
                _produtoInterface.Adicionar(entidade.ToProdutoEntity());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }

        public async Task<List<ProdutoDTO>> Listar()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            try
            {
                var produtosEntity = await _produtoInterface.Listar();

                foreach (var produto in produtosEntity)
                    produtos.Add(new ProdutoDTO() { Id = produto.id, Descricao = produto.descricao, Preco = produto.preco, Nome = produto.nome });
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return produtos;
        }
    }
}
