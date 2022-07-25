using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal interface IFarmaciaService
    {
        List<Farmacia> ObterTodas();
        Farmacia ObterPorId(int id);
        void Cadastrar(Farmacia farmacia);
        void Apagar(int id);
        void Editar(Farmacia farmacia);
    }
}
