using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface ITipoProdutoService
    {
        void Apagar(int id);
        void Cadastrar(TipoProduto1 tipoProduto);
        void Editar(TipoProduto1 tipoProduto);
        List<TipoProduto1> ObterTodos();
        TipoProduto1 ObterPorId(int id);
    }
}
