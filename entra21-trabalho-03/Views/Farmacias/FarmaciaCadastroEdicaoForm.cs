using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Views.Farmacias
{
    public partial class FarmaciaCadastroEdicaoForm : Form
    {
        private readonly int _idParaAlterar;
        private readonly FarmaciaService _farmaciaService;

        private const int modoEdicao = -1;

        public FarmaciaCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaAlterar = modoEdicao;

            _farmaciaService = new FarmaciaService();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FarmaciaCadastroEdicaoForm(Farmacia farmacia) : this()
        {
            _idParaAlterar = farmacia.Id;

            textBoxNomeRedeFarmacia.Text = farmacia.Nome;
            maskedTextBoxCnpj.Text = farmacia.Cnpj;
            textBoxCidade.Text = farmacia.Cidade;
            textBoxBairro.Text = farmacia.Bairro;
            textBoxLogradouro.Text = farmacia.Logradouro;
            textBoxNumero.Text = farmacia.Numero.ToString();
        }

        private void EditarFarmacia(Farmacia farmacia)
        {
            farmacia.Id = _idParaAlterar;

            _farmaciaService.Editar(farmacia);

            MessageBox.Show("Farmacia alterada com sucesso!!");

            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeRedeFarmacia.Text.Trim();
            var cnpj = maskedTextBoxCnpj.Text.Trim();
            var cidade = textBoxCidade.Text.Trim();
            var bairro = textBoxBairro.Text.Trim();
            var logradouro = textBoxLogradouro.Text.Trim();
            int numero;
            try
            {
                numero = Convert.ToInt32(textBoxNumero.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("O campo numero só pode conter numeros inteiros!!");

                textBoxNumero.Focus();

                return;
            }

            try
            {
                var farmacia = new Farmacia();
                farmacia.Nome = nome;
                farmacia.Cnpj = cnpj;
                farmacia.Cidade = cidade;
                farmacia.Bairro = bairro;
                farmacia.Logradouro = logradouro;
                farmacia.Numero = numero;

                if (_idParaAlterar == modoEdicao)
                    CadastrarFarmacia(farmacia);
                else
                    EditarFarmacia(farmacia);
            }
            catch (SqlException)
            {
                MessageBox.Show("Registro não foi salvo com sucesso!!");
            }

        }

        private void CadastrarFarmacia(Farmacia farmacia)
        {
            _farmaciaService.Cadastrar(farmacia);

            MessageBox.Show("Farmacia cadastrada com sucesso!!");

            Close();
        }
    }
}
