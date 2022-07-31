using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

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
            var validarDados = ValidarDadosProduto();

            if (validarDados == false)
                return;

            if (comboBoxTipoProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de produto");
                return;
            }

            var nome = textBoxNomeProduto.Text.Trim();
            var tipoProduto = comboBoxTipoProduto.SelectedItem as TipoProduto1;
            var dataVencimento = dateTimePicker1.Value;
            var preco = Convert.ToDecimal(textBox1.Text);

            var produto = new Produto1();
            produto.Nome = nome;
            produto.TipoProduto = tipoProduto;
            produto.DataVencimento = dataVencimento;
            produto.Preco = preco;

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

        private bool ValidarDadosProduto()
        {
            if(textBoxNomeProduto.Text.Length < 2)
            {
                CustomMessageBox.ShowWarning("Nome inválido, digite um nome com mais de 1 letra");
                textBoxNomeProduto.Focus();
                return false;
            }
            if(comboBoxTipoProduto.SelectedIndex == -1)
            {
                CustomMessageBox.ShowWarning("Selecione um tipo de produto");
                comboBoxTipoProduto.Focus();
                return false;
            }
            if(dateTimePicker1.Value < DateTime.Now)
            {
                CustomMessageBox.ShowWarning("Não é possivel cadastrar um produto vencido");
                dateTimePicker1.Focus();
                return false;
            }
            if(textBox1.Text.Length == 0)
            {
                CustomMessageBox.ShowWarning("Informe o preço do produto");
                textBox1.Focus();
                return false;
            }

            return true;
        }
    }
}
