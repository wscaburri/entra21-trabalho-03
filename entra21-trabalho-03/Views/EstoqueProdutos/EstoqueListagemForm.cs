using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.EstoqueProdutos
{
    public partial class EstoqueListagemForm : Form
    {
        private readonly EstoqueProdutoService _estoqueProdutoService;
        public EstoqueListagemForm()
        {
            InitializeComponent();

            _estoqueProdutoService = new EstoqueProdutoService();

            PreencherDataGridViewComProdutos();
        }

        private void PreencherDataGridViewComProdutos()
        {
            var estoqueProdutos = _estoqueProdutoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < estoqueProdutos.Count; i++)
            {
                var estoqueProduto = estoqueProdutos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    estoqueProduto.Id,
                    estoqueProduto.Farmacia.Nome,
                    estoqueProduto.TipoProduto.Nome,
                    estoqueProduto.Nome,
                    estoqueProduto.QuantidadeProduto,
                    estoqueProduto.ValidadeProduto,
                    estoqueProduto.EntradaProdutoEstoque
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var estoqueProdutoForm = new EstoqueProdutoCadastroEdicaoForm();
            estoqueProdutoForm.ShowDialog();

            PreencherDataGridViewComProdutos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var respostaUsuario = MessageBox.Show("Deseja realmente apagar esse registro?", "AVISO", MessageBoxButtons.YesNo);
            if(respostaUsuario != DialogResult.Yes)
            {
                MessageBox.Show("O registro nao foi apagado!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _estoqueProdutoService.Apagar(id);

            PreencherDataGridViewComProdutos();

            MessageBox.Show("Registro removido com sucesso!!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarDados();
        }

        private void EditarDados()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!!");
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var estoqueProduto = _estoqueProdutoService.ObterPorId(id);

            var estoqueProdutoCadastroEdicaoForm = new EstoqueProdutoCadastroEdicaoForm(estoqueProduto);
            estoqueProdutoCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComProdutos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarDados();
        }
    }//TODO: Reafatora a classe EstoqueListagemForm
}
