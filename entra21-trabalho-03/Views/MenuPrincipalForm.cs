using entra21_trabalho_03.Views.EstoqueProdutos;
using entra21_trabalho_03.Views.Farmacias;

namespace entra21_trabalho_03.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrarFarmacia_Click(object sender, EventArgs e)
        {
            var farmaciaForm = new FarmaciaListagemForm();
            farmaciaForm.ShowDialog();
        }

        private void buttonCadastroEstoque_Click(object sender, EventArgs e)
        {
            var estoqueProdutoForm = new EstoqueListagemForm();
            estoqueProdutoForm.ShowDialog();
        }
    }
}
