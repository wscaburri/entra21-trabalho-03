using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;
using entra21_trabalho_03.Views.Components;

namespace entra21_trabalho_03.Views.EstoqueProdutos
{
    public partial class EstoqueProdutoCadastroEdicaoForm : Form
    {
        private readonly int _idParaAlterar;

        public EstoqueProdutoCadastroEdicaoForm()
        {
            InitializeComponent();

            dateTimePickerDataEntradaEstoque.MaxDate = DateTime.Today;

            PreencherComboBoxComFarmacia();

            PreencherComboBoxComTiposProdutos();

            _idParaAlterar = -1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public EstoqueProdutoCadastroEdicaoForm(EstoqueProduto estoqueProduto) : this()
        {
            _idParaAlterar = estoqueProduto.Id;

            for (int i = 0; i < comboBoxFarmacia.Items.Count; i++)
            {
                var farmaciaPercorrida = comboBoxFarmacia.Items[i] as Farmacia;

                if (farmaciaPercorrida.Id == estoqueProduto.Farmacia.Id)
                {
                    comboBoxFarmacia.SelectedItem = farmaciaPercorrida;
                    break;
                }
            }

            for (int i = 0; i < comboBoxTipoProduto.Items.Count; i++)
            {
                var tipoProdutoPercorrido = comboBoxTipoProduto.Items[i] as TipoProduto1;

                if (tipoProdutoPercorrido.Id == estoqueProduto.TipoProduto.Id)
                {
                    comboBoxTipoProduto.SelectedItem = tipoProdutoPercorrido;
                    break;
                }
            }

            textBoxNomeProduto.Text = estoqueProduto.Nome;
            textBoxQuantidadeProduto.Text = estoqueProduto.QuantidadeProduto.ToString();
            dateTimePickerDataValidade.Text = estoqueProduto.ValidadeProduto.ToString();
            dateTimePickerDataEntradaEstoque.Text = estoqueProduto.EntradaProdutoEstoque.ToString();
        }

        public void PreencherComboBoxComFarmacia()
        {
            var farmaciaService = new FarmaciaService();
            var farmacias = farmaciaService.ObterTodas();

            for (int i = 0; i < farmacias.Count; i++)
            {
                var farmacia = farmacias[i];
                comboBoxFarmacia.Items.Add(farmacia);
            }
        }

        public void PreencherComboBoxComTiposProdutos()
        {
            var tipoProdutoService = new TipoProdutoService();
            var tiposProdutos = tipoProdutoService.ObterTodos();

            for (int i = 0; i < tiposProdutos.Count; i++)
            {
                var tipoProduto = tiposProdutos[i];
                comboBoxTipoProduto.Items.Add(tipoProduto);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var farmacia = comboBoxFarmacia.SelectedItem as Farmacia;
            var tipoProduto = comboBoxTipoProduto.SelectedItem as TipoProduto1;
            var nome = textBoxNomeProduto.Text.Trim();
            var quantidadeProduto = textBoxQuantidadeProduto.Text.Trim();
            var validadeProduto = dateTimePickerDataValidade.Text;
            var dataEntradaEstoque = dateTimePickerDataEntradaEstoque.Text;
            var estoqueProduto = new EstoqueProduto();

            var validarDados = ValidarDadosEstoque();

            if (validarDados == false)
                return;

            estoqueProduto.Farmacia = farmacia;
            estoqueProduto.TipoProduto = tipoProduto;
            estoqueProduto.Nome = nome;
            estoqueProduto.QuantidadeProduto = Convert.ToInt32(quantidadeProduto);
            estoqueProduto.ValidadeProduto = Convert.ToDateTime(validadeProduto);
            estoqueProduto.EntradaProdutoEstoque = Convert.ToDateTime(dataEntradaEstoque);

            var estoqueProdutoService = new EstoqueProdutoService();

            if (_idParaAlterar == -1)
            {
                estoqueProdutoService.Cadastrar(estoqueProduto);

                CustomMessageBox.ShowSuccess("Produto cadastrado com sucesso!");

                Close();
            }
            else
            {
                estoqueProduto.Id = _idParaAlterar;
                estoqueProdutoService.Editar(estoqueProduto);

                CustomMessageBox.ShowSuccess("Produto alterado com sucesso!");

                Close();
            }
        }

        private bool ValidarDadosEstoque()
        {
            int quantidadeProdutos;

            if (comboBoxFarmacia.SelectedIndex == -1)
            {
                CustomMessageBox.ShowWarning("Selecione alguma farmacia!");
                return false;
            }
            if (comboBoxTipoProduto.SelectedIndex == -1)
            {
                CustomMessageBox.ShowWarning("Selecione o tipo do produto!");
                return false;
            }
            if ((textBoxNomeProduto.Text.Length < 3) || (textBoxNomeProduto.Text.Length > 70))
            {
                CustomMessageBox.ShowWarning("O nome do produto deve ser um nome valido!");
                return false;
            }
            try
            {
                quantidadeProdutos = Convert.ToInt32(textBoxQuantidadeProduto.Text);
                if (quantidadeProdutos < 0)
                    return false;
            }
            catch (Exception)
            {
                CustomMessageBox.ShowWarning("A quantidade de produtos não pode ser inferior a zero ou superior a mil!");

                textBoxQuantidadeProduto.Focus();

                return false;
            }
            if (dateTimePickerDataValidade.Value.Date <= DateTime.Today.Date)
            {
                CustomMessageBox.ShowWarning("A data de validade não pode ser o dia atual ou menor que o mesmo!");
                return false;
            }
            if (dateTimePickerDataEntradaEstoque.Value.Date > DateTime.Today.Date)
            {
                CustomMessageBox.ShowWarning("A data de entrada do produto não pode ser superior ao dia atual!");
                return false;
            }

            return true;
        }
    }//TODO: Refatora a classe EstoqueProdutoCadastroEdicaoForm 
}//Olhar try catch quantidade Produtos
