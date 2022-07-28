using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Views.Farmacias
{
    public partial class DistribuidoraCadastroEdicaoForm : Form
    {
        private readonly int _idParaAlterar;
        private readonly DistribuidoraService _farmaciaService;

        private const int modoEdicao = -1;

        public DistribuidoraCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaAlterar = modoEdicao;

            _farmaciaService = new DistribuidoraService();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DistribuidoraCadastroEdicaoForm(Distribuidora farmacia) : this()
        {
            _idParaAlterar = farmacia.Id;

            textBoxNomeRedeFarmacia.Text = farmacia.Nome;
            maskedTextBoxCnpj.Text = farmacia.Cnpj;
            textBoxCidade.Text = farmacia.Cidade;
            textBoxBairro.Text = farmacia.Bairro;
            textBoxLogradouro.Text = farmacia.Logradouro;
            textBoxNumero.Text = farmacia.Numero.ToString();
        }

        private void EditarFarmacia(Distribuidora farmacia)
        {
            farmacia.Id = _idParaAlterar;

            _farmaciaService.Editar(farmacia);

            CustomMessageBox.ShowSuccess("Farmacia alterada com sucesso!!");

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

            var validarDadosFarmacia = ValidarDadosFarmacia();

            if (validarDadosFarmacia == false)
                return;

            try
            {
                numero = Convert.ToInt32(textBoxNumero.Text.Trim());
                if (numero < 0)
                    return;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowError("O campo numero só pode conter numeros inteiros!!");

                textBoxNumero.Focus();

                return;
            }

            var farmacia = new Distribuidora();
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

        private bool ValidarDadosFarmacia()
        {
            if ((textBoxNomeRedeFarmacia.Text.Length < 7) || (textBoxNomeRedeFarmacia.Text.Length > 60))
            {
                CustomMessageBox.ShowError("O nome da farmácia deve conter no minimo 7 caracteres ou no máximo 60");
                return false;
            }
            if (maskedTextBoxCnpj.Text.Length != 18)
            {
                CustomMessageBox.ShowError("O cnpj deve conter todos os seus 14 numeros!");
                return false;
            }
            if ((textBoxCidade.Text.Length < 5) || (textBoxCidade.Text.Length > 100))
            {
                CustomMessageBox.ShowError("O campo cidade deve conter uma cidade valida!");
                return false;
            }
            if ((textBoxBairro.Text.Length < 5) || (textBoxBairro.Text.Length > 100))
            {
                CustomMessageBox.ShowError("O campo bairro deve conter um bairro valido!");
                return false;
            }
            if ((textBoxLogradouro.Text.Length < 5) || (textBoxLogradouro.Text.Length > 100))
            {
                CustomMessageBox.ShowError("O campo logradouro deve conter um logradouro valido!");
                return false;
            }
            return true;
        }

        private void CadastrarFarmacia(Distribuidora farmacia)
        {
            _farmaciaService.Cadastrar(farmacia);

            CustomMessageBox.ShowSuccess("Farmacia cadastrada com sucesso!!");

            Close();
        }
    }
}
