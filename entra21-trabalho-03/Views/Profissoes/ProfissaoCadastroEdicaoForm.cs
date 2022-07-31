using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

namespace entra21_trabalho_03.Views.Profissoes
{
    public partial class ProfissaoCadastroEdicaoForm : Form
    {
        private int _idEdicao = -1;

        public ProfissaoCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public ProfissaoCadastroEdicaoForm(Profissao profissao) : this()
        {
            _idEdicao = profissao.Id;
            textBoxCargo.Text = profissao.Cargo;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var cargo = textBoxCargo.Text.Trim();

            var profissao = new Profissao();
            profissao.Cargo = cargo;

            var profissaoService = new ProfissaoService();

            if (_idEdicao == -1)
            {
                profissaoService.Cadastrar(profissao);

                CustomMessageBox.ShowSuccess("Cargo cadastrado com sucesso!");

                Close();

                return;
            }

            profissao.Id = _idEdicao;
            profissaoService.Editar(profissao);

            CustomMessageBox.ShowSuccess("Cargo alterado com sucesso!");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}