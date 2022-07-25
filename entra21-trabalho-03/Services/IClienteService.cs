using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IClienteService
    {
        void Cadastrar(Cliente cliente);

        List<Cliente> ObterTodos();

        void Apagar(int id);

        Cliente ObterPorId();

        void Editar(Cliente cliente);
    }
}