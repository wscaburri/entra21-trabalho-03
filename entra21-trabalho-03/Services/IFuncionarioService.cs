using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IFuncionarioService
    {
        void Cadastrar(Funcionario cliente);

        List<Funcionario> ObterTodos();

        void Apagar(int id);

        Funcionario ObterPorId(int id);

        void Editar(Funcionario cliente);
    }
}