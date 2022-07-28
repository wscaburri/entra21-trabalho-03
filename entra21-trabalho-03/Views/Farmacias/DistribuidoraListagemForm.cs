using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Views.Farmacias
{
    public partial class DistribuidoraListagemForm : Form
    {
        private readonly DistribuidoraService _farmaciaService;
        public DistribuidoraListagemForm()
        {
            InitializeComponent();

            _farmaciaService = new DistribuidoraService();

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
                CustomMessageBox.ShowWarning("Nenhuma farmacia cadastrada!");
                return;
            }
            if(dataGridView1.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nunhuma farmacia selecionado!");

                return;
            }

            var registroSelecionado = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(registroSelecionado.Cells[0].Value);

                var farmacia = _farmaciaService.ObterPorId(id);

                var farmaciaForm = new DistribuidoraCadastroEdicaoForm(farmacia);
                farmaciaForm.ShowDialog();

                PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var farmacias = _farmaciaService.ObterTodas();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < farmacias.Count; i++)
            {
                var farmacia = farmacias[i];

                dataGridView1.Rows.Add(new object[]
                {
                    farmacia.Id,
                    farmacia.Nome,
                    farmacia.Cnpj,
                    farmacia.Cidade,
                    farmacia.Bairro,
                    farmacia.Logradouro,
                    farmacia.Numero
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhuma farmacia cadastrada!");

                return;
            }

            if(dataGridView1.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhuma farmacia selecionada!");

                return;
            }

            var desejaApagarFarmacia = MessageBox.Show("Deseja realmente apagar essa farmacia?", "CUIDADO!!!", MessageBoxButtons.YesNo);

            if (desejaApagarFarmacia != DialogResult.Yes)
                return;

            var registroSelecionado = dataGridView1.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                _farmaciaService.Apagar(idRegistroSelecionado);

                CustomMessageBox.ShowSuccess("Farmacia apagada com sucesso!!");

                PreencherDataGridView();
            }
            catch(SqlException)
            {
                CustomMessageBox.ShowError("Não foi possivel apgar este registro!!");
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var farmaciaForm = new DistribuidoraCadastroEdicaoForm();

            farmaciaForm.ShowDialog();

            PreencherDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarDados();
        }
    }//TODO: Refatorar FarmaciaListagemForm com novo exemplo do professor
}
