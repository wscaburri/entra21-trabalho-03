using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Funcionarios
{
    public partial class FuncionarioCadastroEdicaoForm : Form
    {
        private readonly int _idEdicao;

        public FuncionarioCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxCargo();

            _idEdicao = -1;
        }

        public FuncionarioCadastroEdicaoForm(Funcionario funcionario) : this()
        {
            _idEdicao = funcionario.Id;
            textBoxNomeCompleto.Text = funcionario.NomeCompleto;
            maskedTextBoxCpf.Text = funcionario.Cpf;
            dateTimePickerDataNascimento.Text = funcionario.DataNascimento.ToString();
            maskedTextBoxCep.Text = funcionario.Cep;
            textBoxEndereco.Text = funcionario.Endereco;
            textBoxNumero.Text = funcionario.Numero.ToString();
            dateTimePickerDataAdmissao.Text = funcionario.DataAdmissao.ToString();
            maskedTextBoxSalario.Text = funcionario.Salario.ToString();

            for (int i = 0; i < comboBoxCargo.Items.Count; i++)
            {
                var profissaoPercorrida = comboBoxCargo.Items[i] as Profissao;

                if (profissaoPercorrida.Id == funcionario.Profissao.Id)
                {
                    comboBoxCargo.SelectedItem = profissaoPercorrida;
                    break;
                }
            }
        }

        private void PreencherComboBoxCargo()
        {
            var profissaoService = new ProfissaoService();
            var profissoes = profissaoService.ObterTodos();

            for (int i = 0; i < profissoes.Count; i++)
            {
                var profissao = profissoes[i];
                comboBoxCargo.Items.Add(profissao);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cargo!");
                return;
            }

            var nome = textBoxNomeCompleto.Text.Trim();
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var cep = maskedTextBoxCep.Text.Trim();
            var endereco = textBoxEndereco.Text.Trim();
            var numero = textBoxNumero.Text.Trim();
            var cargo = comboBoxCargo.SelectedItem as Profissao;
            var dataAdmissao = dateTimePickerDataAdmissao.Value;
            var salario = maskedTextBoxSalario.Text.Trim();

            var funcionario = new Funcionario();
            funcionario.NomeCompleto = nome;
            funcionario.Cpf = cpf;
            funcionario.DataNascimento = dataNascimento;
            funcionario.Cep = cep;
            funcionario.Endereco = endereco;
            funcionario.Numero = Convert.ToInt32(numero);
            funcionario.Profissao = cargo;
            funcionario.DataAdmissao = dataAdmissao;
            funcionario.Salario = Convert.ToDouble(salario);

            var funcionarioService = new FuncionarioService();

            if (_idEdicao == -1)
            {
                funcionarioService.Cadastrar(funcionario);

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                Close();
            }
            else
            {
                funcionario.Id = _idEdicao;

                funcionarioService.Editar(funcionario);

                MessageBox.Show("Funcionário alterado com sucesso!");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}