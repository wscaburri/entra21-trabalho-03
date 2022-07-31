namespace entra21_trabalho_03.Views.EstoqueProdutos
{
    partial class EstoqueListagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeRemedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataEntradaRemedioEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(427, 12);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(346, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(265, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNomeFarmacia,
            this.ColumnTipoProduto,
            this.ColumnNomeProduto,
            this.ColumnQuantidadeRemedio,
            this.ColumnValidadeProduto,
            this.ColumnDataEntradaRemedioEstoque});
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 397);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNomeFarmacia
            // 
            this.ColumnNomeFarmacia.HeaderText = "Nome da Farmacia";
            this.ColumnNomeFarmacia.Name = "ColumnNomeFarmacia";
            this.ColumnNomeFarmacia.ReadOnly = true;
            // 
            // ColumnTipoProduto
            // 
            this.ColumnTipoProduto.HeaderText = "Tipo do Remedio";
            this.ColumnTipoProduto.Name = "ColumnTipoProduto";
            this.ColumnTipoProduto.ReadOnly = true;
            // 
            // ColumnNomeProduto
            // 
            this.ColumnNomeProduto.HeaderText = "Nome do Remedio";
            this.ColumnNomeProduto.Name = "ColumnNomeProduto";
            this.ColumnNomeProduto.ReadOnly = true;
            // 
            // ColumnQuantidadeRemedio
            // 
            this.ColumnQuantidadeRemedio.HeaderText = "Quantidade desejada";
            this.ColumnQuantidadeRemedio.Name = "ColumnQuantidadeRemedio";
            this.ColumnQuantidadeRemedio.ReadOnly = true;
            // 
            // ColumnValidadeProduto
            // 
            this.ColumnValidadeProduto.HeaderText = "Validade do Remedio";
            this.ColumnValidadeProduto.Name = "ColumnValidadeProduto";
            this.ColumnValidadeProduto.ReadOnly = true;
            // 
            // ColumnDataEntradaRemedioEstoque
            // 
            this.ColumnDataEntradaRemedioEstoque.HeaderText = "Data de entrada do remedio no estoque";
            this.ColumnDataEntradaRemedioEstoque.Name = "ColumnDataEntradaRemedioEstoque";
            this.ColumnDataEntradaRemedioEstoque.ReadOnly = true;
            // 
            // EstoqueListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "EstoqueListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem do Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNomeFarmacia;
        private DataGridViewTextBoxColumn ColumnTipoProduto;
        private DataGridViewTextBoxColumn ColumnNomeProduto;
        private DataGridViewTextBoxColumn ColumnQuantidadeRemedio;
        private DataGridViewTextBoxColumn ColumnValidadeProduto;
        private DataGridViewTextBoxColumn ColumnDataEntradaRemedioEstoque;
    }
}