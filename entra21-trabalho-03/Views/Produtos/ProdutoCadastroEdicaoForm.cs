using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Produtos
{
    public partial class ProdutoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        public ProdutoCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxTipoProduto();

            _idParaEditar = -1;
        }

        public ProdutoCadastroEdicaoForm(Produto1 produto) : this()
        {
            _idParaEditar = produto.Id;

            textBoxNomeProduto.Text = produto.Nome;

            for (int i = 0; i < comboBoxTipoProduto.Items.Count; i++)
            {
                var tipoProdutoPercorrido = comboBoxTipoProduto.Items[i] as TipoProduto1;

                if (tipoProdutoPercorrido.Id == produto.TipoProduto.Id)
                {
                    comboBoxTipoProduto.SelectedItem = tipoProdutoPercorrido;
                    break;
                }
            }
        }

        private void PreencherComboBoxTipoProduto()
        {
            var tipoProdutoService = new TipoProdutoService();
            var tipoProdutos = tipoProdutoService.ObterTodos();

            for (int i = 0; i < tipoProdutos.Count; i++)
            {
                var tipoProduto = tipoProdutos[i];
                comboBoxTipoProduto.Items.Add(tipoProduto);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de produto");
                return;
            }

            var nome = textBoxNomeProduto.Text.Trim();
            var tipoProduto = comboBoxTipoProduto.SelectedItem as TipoProduto1;
            var dataVencimento = dateTimePicker1;
            var preco = maskedTextBox1.Text;

            var produto = new Produto1();
            produto.Nome = nome;
            produto.TipoProduto = tipoProduto;
            produto.DataVencimento = Convert.ToDateTime(dataVencimento);
            produto.Preco = Convert.ToDecimal(preco);

            var produtoService = new ProdutoService();

            if (_idParaEditar == -1)
            {
                produtoService.Cadastrar(produto);

                MessageBox.Show("Produto cadastrado com sucesso");
                Close();
            }
            else
            {
                produto.Id = _idParaEditar;

                produtoService.Editar(produto);

                MessageBox.Show("Produto alterado com sucesso");
                Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
