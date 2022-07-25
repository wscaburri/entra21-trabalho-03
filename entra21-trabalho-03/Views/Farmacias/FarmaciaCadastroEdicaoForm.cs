using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Farmacias
{
    public partial class FarmaciaCadastroEdicaoForm : Form
    {
        private readonly int _idParaAlterar;
        private readonly FarmaciaService _farmaciaService;

        private const int modoEdicao = -1;

        public FarmaciaCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaAlterar = modoEdicao;

            _farmaciaService = new FarmaciaService();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FarmaciaCadastroEdicaoForm(Farmacia farmacia) : this()
        {
            _idParaAlterar = farmacia.Id;

            textBoxNomeRedeFarmacia.Text = farmacia.Nome;
            maskedTextBoxCnpj.Text = farmacia.Cnpj;
            textBoxCidade.Text = farmacia.Cidade;
            textBoxBairro.Text = farmacia.Bairro;
            textBoxLogradouro.Text = farmacia.Logradouro;
            textBoxNumero.Text = farmacia.Numero.ToString();
        }
    }
}
