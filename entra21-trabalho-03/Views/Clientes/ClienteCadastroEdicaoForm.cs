using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Clientes
{
    public partial class ClienteCadastroEdicaoForm : Form
    {
        private int idEdicao = -1;

        public ClienteCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        public ClienteCadastroEdicaoForm(Funcionario cliente) : this()
        {
            idEdicao = cliente.Id;
            textBoxNomeCompleto.Text = cliente.NomeCompleto;
            maskedTextBoxCpf.Text = cliente.Cpf;
            dateTimePickerDataNascimento.Text = cliente.DataNascimento.ToString();
            maskedTextBoxCep.Text = cliente.Cep;
            textBoxEndereco.Text = cliente.Endereco;
            textBoxNumero.Text = cliente.Numero.ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeCompleto.Text.Trim();
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var cep = maskedTextBoxCep.Text.Trim();
            var endereco = textBoxEndereco.Text.Trim();
            var numero = textBoxNumero.Text.Trim();

            var cliente = new Funcionario();
            cliente.NomeCompleto = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Cep = cep;
            cliente.Endereco = endereco;
            cliente.Numero = Convert.ToInt32(numero);

            var clienteService = new FuncionarioService();

            if (idEdicao == -1)
            {
                clienteService.Cadastrar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");

                Close();

                return;
            }

            cliente.Id = idEdicao;

            clienteService.Editar(cliente);

            MessageBox.Show("Cliente alterado com sucesso!");

            Close();
        }
    }
}