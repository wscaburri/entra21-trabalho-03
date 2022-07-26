﻿using entra21_trabalho_03.Enums;
using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;
using Newtonsoft.Json;

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
            var nome = textBoxNomeCompleto.Text.Trim();
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var cep = maskedTextBoxCep.Text.Trim();
            var endereco = textBoxEndereco.Text.Trim();
            var numero = textBoxNumero.Text.Trim();
            var cargo = comboBoxCargo.SelectedItem as Profissao;
            var dataAdmissao = dateTimePickerDataAdmissao.Value;
            var salario = maskedTextBoxSalario.Text.Trim();

            var validarDados = ValidarDadosFuncionarios();

            if (validarDados == false)
                return;

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

                CustomMessageBox.ShowSuccess("Funcionário cadastrado com sucesso!");
                Close();
            }
            else
            {
                funcionario.Id = _idEdicao;

                funcionarioService.Editar(funcionario);

                CustomMessageBox.ShowSuccess("Funcionário alterado com sucesso!");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
                return;

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisitos>(resposta);

                textBoxEndereco.Text = $"{dadosEndereco.Logradouro}, {dadosEndereco.Bairro} - {dadosEndereco.Localidade}, {dadosEndereco.Uf}";
            }
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDadosFuncionarios()
        {
            if (textBoxNomeCompleto.Text.Length < 3)
            {
                CustomMessageBox.ShowError("Nome Completo deve conter pelo menos 3 caracteres!");
                return false;
            }

            if (maskedTextBoxCpf.Text.Length != 14)
            {
                CustomMessageBox.ShowError("CPF deve conter 11 digitos!");
                return false;
            }

            if (dateTimePickerDataNascimento.Value > DateTime.Now)
            {
                CustomMessageBox.ShowError("Data de Nascimento não pode ser maior que a data atual!");
                return false;
            }

            if (maskedTextBoxCep.Text.Length != 9)
            {
                CustomMessageBox.ShowError("CEP deve conter 8 digitos!");
                return false;
            }

            if (textBoxEndereco.Text.Length == 0)
            {
                CustomMessageBox.ShowError("Informe um Endereço válido!");
                return false;
            }

            if (textBoxNumero.Text.Length == 0)
            {
                CustomMessageBox.ShowError("Informe o número da residência!");
                return false;
            }

            if (comboBoxCargo.SelectedIndex == -1)
            {
                CustomMessageBox.ShowWarning("Selecione um Cargo!");
                return false;
            }

            if (dateTimePickerDataAdmissao.Value > DateTime.Now)
            {
                CustomMessageBox.ShowError("Data de Admissão não pode ser maior que a data atual!");
                return false;
            }

            if (maskedTextBoxSalario.Text.Length == 0)
            {
                CustomMessageBox.ShowWarning("Informe o salário do funcionário!");
                return false;
            }

            return true;
        }
    }
}