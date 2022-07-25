using entra21_trabalho_03.Services;

namespace entra21_trabalho_03.Views.Farmacias
{
    public partial class FarmaciaListagemForm : Form
    {
        private readonly FarmaciaService _farmaciaService;
        public FarmaciaListagemForm()
        {
            InitializeComponent();

            _farmaciaService = new FarmaciaService();

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
                MessageBox.Show("Nunhuma farmacia cadastrado");

                return;
            }

            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nunhuma farmacia selecionado");

                return;
            }

            var registroSelecionado = dataGridView1.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                var farmacia = _farmaciaService.ObterPorId(idRegistroSelecionado);

                var farmaciaForm = new FarmaciaCadastroEdicaoForm(farmacia);

                farmaciaForm.ShowDialog();

                PreencherDataGridView();
            }
            catch
            {
                MessageBox.Show("Não foi possivel buscar este registro!");
            }
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
                MessageBox.Show("Nenhuma farmacia cadastrada!");

                return;
            }

            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma farmacia selecionada!");

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

                MessageBox.Show("Farmacia apagada com sucesso!!");

                PreencherDataGridView();
            }
            catch
            {
                MessageBox.Show("Não foi possivel apgar este registro!!");
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }
    }//TODO: Refatorar FarmaciaListagemForm com novo exemplo do professor
}
