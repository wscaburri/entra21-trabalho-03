using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IEstoqueProdutoService
    {
        List<EstoqueProduto> ObterTodos();
        EstoqueProduto ObterPorId(int id);
        void Cadastrar(EstoqueProduto estoqueProduto);
        void Editar(EstoqueProduto estoqueProduto);

        void Apagar(int id);

    }
}
