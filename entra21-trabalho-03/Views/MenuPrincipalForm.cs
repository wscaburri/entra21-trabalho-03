using entra21_trabalho_03.Views.Distribuidoras;
using entra21_trabalho_03.Views.EstoqueProdutos;
using entra21_trabalho_03.Views.Funcionarios;
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
            var clienteForm = new FuncionarioListagemForm();
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

        private void buttonCadastrarDistribuidora_Click(object sender, EventArgs e)
        {
            var distribuidoraForm = new DistribuidoraListagemForm();
            distribuidoraForm.ShowDialog();
        }
    }
}