using entra21_trabalho_03.Models;
using entra21_trabalho_03.Services;

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

            for(int i = 0; i < comboBoxFarmacia.Items.Count; i++)
            {
                var farmaciaPercorrida = comboBoxFarmacia.Items[i] as Farmacia;

                if(farmaciaPercorrida.Id == estoqueProduto.Farmacia.Id)
                {
                    comboBoxFarmacia.SelectedItem = farmaciaPercorrida;
                    break;
                }
            }

            for(int i = 0; i < comboBoxTipoProduto.Items.Count; i++)
            {
                var tipoProdutoPercorrido = comboBoxTipoProduto.Items[i] as TipoProduto;

                if(tipoProdutoPercorrido.Id == estoqueProduto.TipoProduto.Id)
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

            for(int i = 0; i < farmacias.Count; i++)
            {
                var farmacia = farmacias[i];
                comboBoxFarmacia.Items.Add(farmacia);
            }
        }

        public void PreencherComboBoxComTiposProdutos()
        {
            var tipoProdutoService = new TipoProdutoService();
            var tiposProdutos = tipoProdutoService.ObterTodos();

            for(int i = 0; i < tiposProdutos.Count; i++)
            {
                var tipoProduto = tiposProdutos[i];
                comboBoxTipoProduto.Items.Add(tipoProduto);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var farmacia = comboBoxFarmacia.SelectedItem as Farmacia;
            var tipoProduto = comboBoxTipoProduto.SelectedItem as TipoProduto;
            var nome = textBoxNomeProduto.Text.Trim();
            var quantidadeProduto = textBoxQuantidadeProduto.Text.Trim();
            var validadeProduto = dateTimePickerDataValidade.Text;
            var dataEntradaEstoque = dateTimePickerDataEntradaEstoque.Text;
            var estoqueProduto = new EstoqueProduto();

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

                MessageBox.Show("Produto cadastrado com sucesso!");
                
                Close();
            }
            else
            {
                estoqueProduto.Id = _idParaAlterar;
                estoqueProdutoService.Editar(estoqueProduto);

                MessageBox.Show("Produto alterado com sucesso!");

                Close();
            }
        }
    }
}
