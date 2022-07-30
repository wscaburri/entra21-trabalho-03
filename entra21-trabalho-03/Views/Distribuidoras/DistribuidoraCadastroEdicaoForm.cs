using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Views.Distribuidoras
{
    public partial class DistribuidoraCadastroEdicaoForm : Form
    {
        private readonly int _idParaAlterar;
        private readonly DistribuidoraService _distribuidoraService;

        private const int modoEdicao = -1;

        public DistribuidoraCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaAlterar = modoEdicao;

            _distribuidoraService = new DistribuidoraService();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DistribuidoraCadastroEdicaoForm(Distribuidora Distribuidora) : this()
        {
            _idParaAlterar = Distribuidora.Id;

            textBoxNome.Text = Distribuidora.Nome;
            maskedTextBoxCnpj.Text = Distribuidora.Cnpj;
            textBoxEstado.Text = Distribuidora.Estado;
            textBoxCidade.Text = Distribuidora.Cidade;
            textBoxBairro.Text = Distribuidora.Bairro;
            textBoxLogradouro.Text = Distribuidora.Logradouro;
            textBoxNumero.Text = Distribuidora.Numero.ToString();
        }

        private void EditarDistribuidora(Distribuidora distribuidora)
        {
            distribuidora.Id = _idParaAlterar;

            _distribuidoraService.Editar(distribuidora);

            CustomMessageBox.ShowSuccess("Distribuidora alterada com sucesso!!");

            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var cnpj = maskedTextBoxCnpj.Text.Trim();
            var estado = textBoxEstado.Text.Trim();
            var cidade = textBoxCidade.Text.Trim();
            var bairro = textBoxBairro.Text.Trim();
            var logradouro = textBoxLogradouro.Text.Trim();
            int numero;

            var validarDadosDistribuidora = ValidarDadosDistribuidora();

            if (validarDadosDistribuidora == false)
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

            var Distribuidora = new Distribuidora();
            Distribuidora.Nome = nome;
            Distribuidora.Cnpj = cnpj;
            Distribuidora.Estado = estado;
            Distribuidora.Cidade = cidade;
            Distribuidora.Bairro = bairro;
            Distribuidora.Logradouro = logradouro;
            Distribuidora.Numero = numero;


            if (_idParaAlterar == modoEdicao)
                CadastrarDistribuidora(Distribuidora);
            else
                EditarDistribuidora(Distribuidora);
        }

        private bool ValidarDadosDistribuidora()
        {
            if ((textBoxNome.Text.Length < 7) || (textBoxNome.Text.Length > 60))
            {
                CustomMessageBox.ShowError("O nome da distribuidora deve conter no minimo 7 caracteres ou no máximo 60");
                return false;
            }
            if (maskedTextBoxCnpj.Text.Length != 18)
            {
                CustomMessageBox.ShowError("O cnpj deve conter todos os seus 14 numeros!");
                return false;
            }
            if((textBoxEstado.Text.Length < 3) || (textBoxEstado.Text.Length > 100))
            {
                CustomMessageBox.ShowError("O estado deve conter um nome valido!");
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

        private void CadastrarDistribuidora(Distribuidora distribuidora)
        {
            _distribuidoraService.Cadastrar(distribuidora);

            CustomMessageBox.ShowSuccess("Distribuidora cadastrada com sucesso!!");

            Close();
        }
    }
}
