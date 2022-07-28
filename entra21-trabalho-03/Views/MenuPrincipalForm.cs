using entra21_trabalho_03.Views.Clientes;
using entra21_trabalho_03.Views.EstoqueProdutos;
using entra21_trabalho_03.Views.Farmacias;
using entra21_trabalho_03.Views.TipoProdutos;

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

        private void buttonTipoProduto_Click(object sender, EventArgs e)
        {
            var tipoProdutoForm = new TipoProdutoListagemForm();
            tipoProdutoForm.ShowDialog();
        }

        private void buttonCadastroCliente_Click(object sender, EventArgs e)
        {
            var clienteForm = new ClienteListagemForm();
            clienteForm.ShowDialog();
        }
    }
}