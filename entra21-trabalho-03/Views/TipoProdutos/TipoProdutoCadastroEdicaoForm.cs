using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

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
            var produto = textBoxTipoProd.Text.Trim();
           
            var tipoProduto = new TipoProduto1();
            tipoProduto.Nome = produto;

            var tipoProdutoService = new TipoProdutoService();
                       
            if (idEdicao == -1)
            {
                tipoProdutoService.Cadastrar(tipoProduto);

                MessageBox.Show("Tipo de produto salvo");

                Close();

                return;
            }

            tipoProduto.Id = idEdicao;
            tipoProdutoService.Editar(tipoProduto);

            MessageBox.Show("Tipo de produto alterado com sucesso");
            
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
