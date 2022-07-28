namespace entra21_trabalho_03.Views
{
    partial class MenuPrincipalForm
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
            this.buttonCadastroCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTipoProduto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCadastrarFarmacia = new System.Windows.Forms.Button();
            this.buttonCadastroEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroCliente
            // 
            this.buttonCadastroCliente.Location = new System.Drawing.Point(14, 33);
            this.buttonCadastroCliente.Name = "buttonCadastroCliente";
            this.buttonCadastroCliente.Size = new System.Drawing.Size(123, 94);
            this.buttonCadastroCliente.TabIndex = 0;
            this.buttonCadastroCliente.Text = "Cadastro de Cliente";
            this.buttonCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCadastroCliente.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 94);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonTipoProduto
            // 
            this.buttonTipoProduto.Location = new System.Drawing.Point(276, 33);
            this.buttonTipoProduto.Name = "buttonTipoProduto";
            this.buttonTipoProduto.Size = new System.Drawing.Size(123, 94);
            this.buttonTipoProduto.TabIndex = 2;
            this.buttonTipoProduto.Text = "Tipo de Produto";
            this.buttonTipoProduto.UseVisualStyleBackColor = true;
            this.buttonTipoProduto.Click += new System.EventHandler(this.buttonTipoProduto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarFarmacia
            // 
            this.buttonCadastrarFarmacia.Location = new System.Drawing.Point(143, 150);
            this.buttonCadastrarFarmacia.Name = "buttonCadastrarFarmacia";
            this.buttonCadastrarFarmacia.Size = new System.Drawing.Size(127, 85);
            this.buttonCadastrarFarmacia.TabIndex = 4;
            this.buttonCadastrarFarmacia.Text = "Cadastro de Farmacia";
            this.buttonCadastrarFarmacia.UseVisualStyleBackColor = true;
            this.buttonCadastrarFarmacia.Click += new System.EventHandler(this.buttonCadastrarFarmacia_Click);
            // 
            // buttonCadastroEstoque
            // 
            this.buttonCadastroEstoque.Location = new System.Drawing.Point(276, 150);
            this.buttonCadastroEstoque.Name = "buttonCadastroEstoque";
            this.buttonCadastroEstoque.Size = new System.Drawing.Size(123, 85);
            this.buttonCadastroEstoque.TabIndex = 5;
            this.buttonCadastroEstoque.Text = "Cadastro de Estoque";
            this.buttonCadastroEstoque.UseVisualStyleBackColor = true;
            this.buttonCadastroEstoque.Click += new System.EventHandler(this.buttonCadastroEstoque_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 253);
            this.Controls.Add(this.buttonCadastroEstoque);
            this.Controls.Add(this.buttonCadastrarFarmacia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTipoProduto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCadastroCliente);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastroCliente;
        private Button button2;
        private Button buttonTipoProduto;
        private Button button4;
        private Button buttonCadastrarFarmacia;
        private Button buttonCadastroEstoque;
    }
}