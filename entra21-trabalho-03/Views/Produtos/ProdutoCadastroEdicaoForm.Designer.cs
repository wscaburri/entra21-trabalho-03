namespace entra21_trabalho_03.Views.Produtos
{
    partial class ProdutoCadastroEdicaoForm
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
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.labelTipoProduto = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDataVencimento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(12, 29);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(465, 27);
            this.textBoxNomeProduto.TabIndex = 0;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeProduto.Location = new System.Drawing.Point(12, 1);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(164, 25);
            this.labelNomeProduto.TabIndex = 1;
            this.labelNomeProduto.Text = "Nome do Produto";
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(12, 94);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(330, 28);
            this.comboBoxTipoProduto.TabIndex = 2;
            // 
            // labelTipoProduto
            // 
            this.labelTipoProduto.AutoSize = true;
            this.labelTipoProduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoProduto.Location = new System.Drawing.Point(12, 68);
            this.labelTipoProduto.Name = "labelTipoProduto";
            this.labelTipoProduto.Size = new System.Drawing.Size(142, 23);
            this.labelTipoProduto.TabIndex = 3;
            this.labelTipoProduto.Text = "Tipo do Produto";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelDataVencimento
            // 
            this.labelDataVencimento.AutoSize = true;
            this.labelDataVencimento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataVencimento.Location = new System.Drawing.Point(12, 134);
            this.labelDataVencimento.Name = "labelDataVencimento";
            this.labelDataVencimento.Size = new System.Drawing.Size(147, 23);
            this.labelDataVencimento.TabIndex = 6;
            this.labelDataVencimento.Text = "Data de Validade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(330, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço Unitário";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 216);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(383, 216);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(330, 157);
            this.maskedTextBox1.Mask = "R$ 000,00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // ProdutoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 272);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDataVencimento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTipoProduto);
            this.Controls.Add(this.comboBoxTipoProduto);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Name = "ProdutoCadastroEdicaoForm";
            this.Text = "ProdutoCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNomeProduto;
        private Label labelNomeProduto;
        private ComboBox comboBoxTipoProduto;
        private Label labelTipoProduto;
        private DateTimePicker dateTimePicker1;
        private Label labelDataVencimento;
        private Label label4;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private MaskedTextBox maskedTextBox1;
    }
}