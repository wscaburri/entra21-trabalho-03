using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IPedidoService
    {
        void Cadastrar(Pedido pedido);

        void Editar(Pedido pedido);

        void Apagar(int id);

        Pedido ObterPorId(int id);

        List<Pedido> ObterTodos();
    }
}