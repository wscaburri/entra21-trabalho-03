using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.TipoProduto;

namespace entra21_trabalho_03.Views.TipoProdutos
{
    public partial class TipoProdutoListagemForm : Form
    {
        private TipoProdutoService tipoProdutoService;

        public TipoProdutoListagemForm()
        {
            InitializeComponent();

            tipoProdutoService = new TipoProdutoService();
        }

        private void TipoProdutoListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoProdutoCadastroEdicaoForm = new TipoProdutoCadastroEdicaoForm();

            tipoProdutoCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            var tipoProdutos = tipoProdutoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < tipoProdutos.Count; i++)
            {
                var tipoProduto = tipoProdutos[i];

                dataGridView1.Rows.Add(new object[]
                        {
                    tipoProduto.Id,
                    tipoProduto.Nome
                        });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoProdutoService.Apagar(id);

            AtualizarRegistrosDataGridView();

            MessageBox.Show("Registro apagado com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum tipo de produto");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum produto");
                return;
            }


            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var tipoProduto = tipoProdutoService.ObterPorId(id);

            var tipoProdutoForm = new TipoProdutoCadastroEdicaoForm(tipoProduto);
            tipoProdutoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
    }
}
