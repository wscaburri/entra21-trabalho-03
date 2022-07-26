using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface ITipoProdutoService
    {
        void Apagar(int id);
        void Cadastrar(TipoProduto tipoProduto);
        void Editar(TipoProduto tipoProduto);
        List<TipoProduto> ObterTodos();
        TipoProduto ObterPorId(int id);
    }
}
