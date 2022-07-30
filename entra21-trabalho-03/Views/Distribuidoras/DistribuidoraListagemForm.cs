using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Views.Distribuidoras
{
    public partial class DistribuidoraListagemForm : Form
    {
        private readonly DistribuidoraService _distribuidoraService;
        public DistribuidoraListagemForm()
        {
            InitializeComponent();

            _distribuidoraService = new DistribuidoraService();

            PreencherDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarDados();
        }

        private void EditarDados()
        {
            if(dataGridView1.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhuma distribuidora cadastrada!");
                return;
            }
            if(dataGridView1.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nunhuma distribuidora selecionado!");

                return;
            }

            var registroSelecionado = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(registroSelecionado.Cells[0].Value);

                var distribuidora = _distribuidoraService.ObterPorId(id);

                var distribuidoraForm = new DistribuidoraCadastroEdicaoForm(distribuidora);
                distribuidoraForm.ShowDialog();

                PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var distribuidoras = _distribuidoraService.ObterTodas();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < distribuidoras.Count; i++)
            {
                var distribuidora = distribuidoras[i];

                dataGridView1.Rows.Add(new object[]
                {
                    distribuidora.Id,
                    distribuidora.Nome,
                    distribuidora.Cnpj,
                    distribuidora.Cep,
                    distribuidora.Estado,
                    distribuidora.Cidade,
                    distribuidora.Bairro,
                    distribuidora.Logradouro,
                    distribuidora.Numero
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhuma distribuidora cadastrada!");

                return;
            }

            if(dataGridView1.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhuma distribuidora selecionada!");

                return;
            }

            var desejaApagarDistribuidora = MessageBox.Show("Deseja realmente apagar essa distribuidora?", "CUIDADO!!!", MessageBoxButtons.YesNo);

            if (desejaApagarDistribuidora != DialogResult.Yes)
                return;

            var registroSelecionado = dataGridView1.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                _distribuidoraService.Apagar(idRegistroSelecionado);

                CustomMessageBox.ShowSuccess("Distribuidora apagada com sucesso!!");

                PreencherDataGridView();
            }
            catch(SqlException)
            {
                CustomMessageBox.ShowError("Não foi possivel apgar este registro!!");
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var distribuidoraForm = new DistribuidoraCadastroEdicaoForm();

            distribuidoraForm.ShowDialog();

            PreencherDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarDados();
        }
    }//TODO: Refatorar DistribuidoraListagemForm com novo exemplo do professor
}
