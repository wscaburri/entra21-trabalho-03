using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IProfissaoService
    {
        void Cadastrar(Profissao pedido);

        void Editar(Profissao pedido);

        void Apagar(int id);

        Profissao ObterPorId(int id);

        List<Profissao> ObterTodos();
    }
}