namespace entra21_trabalho_03.Views.EstoqueProdutos
{
    partial class EstoqueProdutoCadastroEdicaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDistribuidora = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataValidade = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataEntradaEstoque = new System.Windows.Forms.DateTimePicker();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribuidora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade Desejada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de entrada no estoque";
            // 
            // comboBoxDistribuidora
            // 
            this.comboBoxDistribuidora.DisplayMember = "Nome";
            this.comboBoxDistribuidora.FormattingEnabled = true;
            this.comboBoxDistribuidora.Location = new System.Drawing.Point(14, 56);
            this.comboBoxDistribuidora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDistribuidora.Name = "comboBoxDistribuidora";
            this.comboBoxDistribuidora.Size = new System.Drawing.Size(217, 28);
            this.comboBoxDistribuidora.TabIndex = 6;
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.DisplayMember = "Nome";
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(14, 115);
            this.comboBoxTipoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(217, 28);
            this.comboBoxTipoProduto.TabIndex = 7;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(14, 173);
            this.textBoxNomeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(217, 27);
            this.textBoxNomeProduto.TabIndex = 8;
            // 
            // textBoxQuantidadeProduto
            // 
            this.textBoxQuantidadeProduto.Location = new System.Drawing.Point(14, 232);
            this.textBoxQuantidadeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantidadeProduto.Name = "textBoxQuantidadeProduto";
            this.textBoxQuantidadeProduto.Size = new System.Drawing.Size(217, 27);
            this.textBoxQuantidadeProduto.TabIndex = 9;
            // 
            // dateTimePickerDataValidade
            // 
            this.dateTimePickerDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataValidade.Location = new System.Drawing.Point(14, 291);
            this.dateTimePickerDataValidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataValidade.Name = "dateTimePickerDataValidade";
            this.dateTimePickerDataValidade.Size = new System.Drawing.Size(217, 27);
            this.dateTimePickerDataValidade.TabIndex = 10;
            // 
            // dateTimePickerDataEntradaEstoque
            // 
            this.dateTimePickerDataEntradaEstoque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataEntradaEstoque.Location = new System.Drawing.Point(14, 349);
            this.dateTimePickerDataEntradaEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataEntradaEstoque.Name = "dateTimePickerDataEntradaEstoque";
            this.dateTimePickerDataEntradaEstoque.Size = new System.Drawing.Size(217, 27);
            this.dateTimePickerDataEntradaEstoque.TabIndex = 11;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(143, 409);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 65);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(14, 409);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 65);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // EstoqueProdutoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 485);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dateTimePickerDataEntradaEstoque);
            this.Controls.Add(this.dateTimePickerDataValidade);
            this.Controls.Add(this.textBoxQuantidadeProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.comboBoxTipoProduto);
            this.Controls.Add(this.comboBoxDistribuidora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EstoqueProdutoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto no Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxDistribuidora;
        private ComboBox comboBoxTipoProduto;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxQuantidadeProduto;
        private DateTimePicker dateTimePickerDataValidade;
        private DateTimePicker dateTimePickerDataEntradaEstoque;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}