using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

namespace entra21_trabalho_03.Views.Funcionarios
{
    public partial class FuncionarioListagemForm : Form
    {
        private readonly FuncionarioService _funcionarioService;

        public FuncionarioListagemForm()
        {
            InitializeComponent();

            _funcionarioService = new FuncionarioService();

            PreencherDataGridViewComFuncionarios();
        }

        private void PreencherDataGridViewComFuncionarios()
        {
            var funcionarios = _funcionarioService.ObterTodos();

            dataGridViewFuncionarios.Rows.Clear();

            for (int i = 0; i < funcionarios.Count; i++)
            {
                var funcionario = funcionarios[i];

                dataGridViewFuncionarios.Rows.Add(new object[]
                {
                    funcionario.Id,
                    funcionario.NomeCompleto,
                    funcionario.Cpf,
                    funcionario.Profissao.Cargo,
                    funcionario.Salario,
                    funcionario.DataAdmissao.ToString("dd/MM/yyyy"),
                    funcionario.DataNascimento.ToString("dd/MM/yyyy"),
                    funcionario.Cep,
                    funcionario.Endereco,
                    funcionario.Numero
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var funcionarioForm = new FuncionarioCadastroEdicaoForm();
            funcionarioForm.ShowDialog();

            PreencherDataGridViewComFuncionarios();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Selecione um Funcionário!");
                return;
            }

            var apagarRegistro = MessageBox.Show("Deseja realmente apagar o registro do funcionário?", "ALERTA", MessageBoxButtons.YesNo);

            if (apagarRegistro != DialogResult.Yes)
            {
                CustomMessageBox.ShowError("Operação Cancelada. O registro continua salvo!");
                return;
            }

            var id = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells[0].Value);

            _funcionarioService.Apagar(id);

            PreencherDataGridViewComFuncionarios();

            CustomMessageBox.ShowSuccess("Funcionário removido com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Selecione algum Funcionário!");
                return;
            }

            var id = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells[0].Value);

            var funcionario = _funcionarioService.ObterPorId(id);

            var funcionarioCadastroForm = new FuncionarioCadastroEdicaoForm(funcionario);
            funcionarioCadastroForm.ShowDialog();

            PreencherDataGridViewComFuncionarios();
        }
    }
}