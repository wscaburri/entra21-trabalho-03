using entra21_trabalho_03.Services;
using System.Globalization;

namespace entra21_trabalho_03.Views.Produtos
{
    public partial class ProdutoListagemForm : Form
    {
        private readonly ProdutoService _produtoService;

        public ProdutoListagemForm()
        {
            InitializeComponent();

            _produtoService = new ProdutoService();

            PreencherDataGridViewComProdutoCadastrado();
        }

        private void PreencherDataGridViewComProdutoCadastrado()
        {
            var produto = _produtoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < produto.Count; i++)
            {
                var produtos = produto[i];

                dataGridView1.Rows.Add(new object[]
                {
                    produtos.Id,
                    produtos.Nome,
                    produtos.TipoProduto.Nome,
                    produtos.DataVencimento.ToString("dd/MM/yyyy"),
                    ObterValorFormatado(produtos.Preco)
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por gentileza, selecione um produto");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var produto = _produtoService.ObterPorId(id);

            var produtoForm = new ProdutoCadastroEdicaoForm(produto);
            produtoForm.ShowDialog();

            PreencherDataGridViewComProdutoCadastrado();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _produtoService.Apagar(id);

            PreencherDataGridViewComProdutoCadastrado();

            MessageBox.Show("Registro removido com sucesso");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var produtoForm = new ProdutoCadastroEdicaoForm();
            produtoForm.ShowDialog();

            PreencherDataGridViewComProdutoCadastrado();
        }

        public static string ObterValorFormatado(decimal valor)
        {
            var cultura = new CultureInfo("pt-BR");
            cultura.NumberFormat.NumberDecimalDigits = 2;
            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.CurrencyGroupSeparator = ".";

            return string.Format(cultura, "R$ {0:N}", valor);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
