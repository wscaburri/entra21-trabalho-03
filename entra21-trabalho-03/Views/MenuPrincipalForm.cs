using entra21_trabalho_03.Views.Clientes;
using entra21_trabalho_03.Views.EstoqueProdutos;
using entra21_trabalho_03.Views.Farmacias;
using entra21_trabalho_03.Views.Produtos;
using entra21_trabalho_03.Views.Profissoes;
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
            var farmaciaForm = new DistribuidoraListagemForm();
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

        private void buttonCadastroProduto_Click(object sender, EventArgs e)
        {
            var produtoForm = new ProdutoCadastroEdicaoForm();
            produtoForm.ShowDialog();
        }

        private void buttonCadastroProfissao_Click(object sender, EventArgs e)
        {
            var profissaoForm = new ProfissaoListagemForm();
            profissaoForm.ShowDialog();
        }
    }
}