using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Clientes
{
    public partial class ClienteListagemForm : Form
    {
        private FuncionarioService clienteService;

        public ClienteListagemForm()
        {
            InitializeComponent();

            clienteService = new FuncionarioService();
        }

        private void AtualizarRegistroDataGridView()
        {
            var clientes = clienteService.ObterTodos();

            dataGridViewClientes.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                dataGridViewClientes.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.NomeCompleto,
                    cliente.Cpf,
                    cliente.DataNascimento,
                    cliente.Cep,
                    cliente.Endereco,
                    cliente.Numero
                });
            }
        }

        private void ClienteListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var clienteCadastroEdicaoForm = new ClienteCadastroEdicaoForm();

            clienteCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells[0].Value);

            clienteService.Apagar(id);

            AtualizarRegistroDataGridView();

            MessageBox.Show("Cliente apagado com sucesso!");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado!");
                return;
            }

            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum cliente!");
                return;
            }

            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var cliente = clienteService.ObterPorId(id);
            var clienteForm = new ClienteCadastroEdicaoForm(cliente);

            clienteForm.ShowDialog();

            AtualizarRegistroDataGridView();
        }
    }
}