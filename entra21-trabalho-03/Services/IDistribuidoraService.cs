using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IDistribuidoraService
    {
        List<Distribuidora> ObterTodas();
        Distribuidora ObterPorId(int id);
        void Cadastrar(Distribuidora farmacia);
        void Apagar(int id);
        void Editar(Distribuidora farmacia);
    }
}
