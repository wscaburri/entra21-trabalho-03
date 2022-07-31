using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

namespace entra21_trabalho_03.Views.TipoProduto
{
    public partial class TipoProdutoCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;

        public TipoProdutoCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public TipoProdutoCadastroEdicaoForm(TipoProduto1 tipoProduto) : this()
        {
            idEdicao = tipoProduto.Id;

            textBoxTipoProd.Text = tipoProduto.Nome;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var validacao = ValidarDadosTipoProduto();

            if (validacao == false)
                return;

            var produto = textBoxTipoProd.Text.Trim();

            var tipoProduto = new TipoProduto1();
            tipoProduto.Nome = produto;

            var tipoProdutoService = new TipoProdutoService();

            if (idEdicao == -1)
            {
                tipoProdutoService.Cadastrar(tipoProduto);

                CustomMessageBox.ShowSuccess("Tipo de produto salvo");

                Close();

                return;
            }

            tipoProduto.Id = idEdicao;
            tipoProdutoService.Editar(tipoProduto);

            CustomMessageBox.ShowSuccess("Tipo de produto alterado com sucesso");

            Close();
        }

        private bool ValidarDadosTipoProduto()
        {
            if (textBoxTipoProd.Text.Length < 2)
            {
                CustomMessageBox.ShowWarning("Nome inválido, digite um nome com mais de 1 letra");
                textBoxTipoProd.Focus();
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
