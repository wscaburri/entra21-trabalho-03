using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IProdutoService
    {
        List<Produto1> ObterTodos();
        Produto1 ObterPorId(int id);
        void Cadastrar(Produto1 personagem);
        void Editar(Produto1 personagem);
        void Apagar(int id);
    }
}
