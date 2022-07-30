using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Profissoes
{
    public partial class ProfissaoListagemForm : Form
    {
        private ProfissaoService profissaoService;

        public ProfissaoListagemForm()
        {
            InitializeComponent();

            profissaoService = new ProfissaoService();
        }

        private void AtualizarRegistrosDataGridView()
        {
            var profissoes = profissaoService.ObterTodos();

            dataGridViewProfissoes.Rows.Clear();

            for (int i = 0; i < profissoes.Count; i++)
            {
                var profissao = profissoes[i];

                dataGridViewProfissoes.Rows.Add(new object[]
                {
                    profissao.Id,
                    profissao.Cargo
                });
            }
        }

        private void ProfissaoListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }

        private void buttonCadatrar_Click(object sender, EventArgs e)
        {
            var profissaoCadastroEdicaoForm = new ProfissaoCadastroEdicaoForm();

            profissaoCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfissoes.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum cargo!");
                return;
            }

            if (dataGridViewProfissoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum cargo!");
                return;
            }

            var linhaSelecionada = dataGridViewProfissoes.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var profissao = profissaoService.ObterPorId(id);

            var profissaoForm = new ProfissaoCadastroEdicaoForm(profissao);

            profissaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }
    }
}