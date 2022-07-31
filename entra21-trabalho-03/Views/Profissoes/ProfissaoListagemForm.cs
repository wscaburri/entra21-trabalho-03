using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

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
                CustomMessageBox.ShowWarning("Cadastre algum cargo!");
                return;
            }

            if (dataGridViewProfissoes.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Selecione algum cargo!");
                return;
            }

            var id = Convert.ToInt32(dataGridViewProfissoes.SelectedRows[0].Cells[0].Value);

            var profissao = profissaoService.ObterPorId(id);

            var profissaoForm = new ProfissaoCadastroEdicaoForm(profissao);

            profissaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfissoes.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Selecione algum cargo!");
                return;
            }

            try
            {
                var apagarRegistro = MessageBox.Show("Deseja realmente apagar o registro desse cargo?", "ALERTA", MessageBoxButtons.YesNo);

                if (apagarRegistro != DialogResult.Yes)
                {
                    CustomMessageBox.ShowError("Operação Cancelada. O registro continua salvo!");
                    return;
                }

                var id = Convert.ToInt32(dataGridViewProfissoes.SelectedRows[0].Cells[0].Value);

                profissaoService.Apagar(id);

                AtualizarRegistrosDataGridView();

                CustomMessageBox.ShowSuccess("Registro de cargo apagado com sucesso!");
            }
            catch (Exception)
            {
                CustomMessageBox.ShowError("Operação não permitida. Cargo vinculado à um Funcionário!");
            }
        }
    }
}