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
            this.buttonCadastroProduto = new System.Windows.Forms.Button();
            this.buttonCadastrarFarmacia = new System.Windows.Forms.Button();
            this.buttonCadastroEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroCliente
            // 
            this.buttonCadastroCliente.Location = new System.Drawing.Point(16, 44);
            this.buttonCadastroCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastroCliente.Name = "buttonCadastroCliente";
            this.buttonCadastroCliente.Size = new System.Drawing.Size(184, 151);
            this.buttonCadastroCliente.TabIndex = 0;
            this.buttonCadastroCliente.Text = "Cadastro de Cliente";
            this.buttonCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCadastroCliente.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 151);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonTipoProduto
            // 
            this.buttonTipoProduto.Location = new System.Drawing.Point(431, 44);
            this.buttonTipoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTipoProduto.Name = "buttonTipoProduto";
            this.buttonTipoProduto.Size = new System.Drawing.Size(184, 151);
            this.buttonTipoProduto.TabIndex = 2;
            this.buttonTipoProduto.Text = "Cadastro de Tipo de Produto";
            this.buttonTipoProduto.UseVisualStyleBackColor = true;
            this.buttonTipoProduto.Click += new System.EventHandler(this.buttonTipoProduto_Click);
            // 
            // buttonCadastroProduto
            // 
            this.buttonCadastroProduto.Location = new System.Drawing.Point(16, 237);
            this.buttonCadastroProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastroProduto.Name = "buttonCadastroProduto";
            this.buttonCadastroProduto.Size = new System.Drawing.Size(184, 151);
            this.buttonCadastroProduto.TabIndex = 3;
            this.buttonCadastroProduto.Text = "Cadastro de Produtos";
            this.buttonCadastroProduto.UseVisualStyleBackColor = true;
            this.buttonCadastroProduto.Click += new System.EventHandler(this.buttonCadastroProduto_Click);
            // 
            // buttonCadastrarFarmacia
            // 
            this.buttonCadastrarFarmacia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarFarmacia.Image = global::entra21_trabalho_03.Properties.Resources.pharmacy;
            this.buttonCadastrarFarmacia.Location = new System.Drawing.Point(225, 237);
            this.buttonCadastrarFarmacia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastrarFarmacia.Name = "buttonCadastrarFarmacia";
            this.buttonCadastrarFarmacia.Size = new System.Drawing.Size(184, 151);
            this.buttonCadastrarFarmacia.TabIndex = 4;
            this.buttonCadastrarFarmacia.Text = "Cadastro de Farmacia";
            this.buttonCadastrarFarmacia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastrarFarmacia.UseVisualStyleBackColor = true;
            this.buttonCadastrarFarmacia.Click += new System.EventHandler(this.buttonCadastrarFarmacia_Click);
            // 
            // buttonCadastroEstoque
            // 
            this.buttonCadastroEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastroEstoque.Image = global::entra21_trabalho_03.Properties.Resources.inventory;
            this.buttonCadastroEstoque.Location = new System.Drawing.Point(431, 237);
            this.buttonCadastroEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastroEstoque.Name = "buttonCadastroEstoque";
            this.buttonCadastroEstoque.Size = new System.Drawing.Size(184, 151);
            this.buttonCadastroEstoque.TabIndex = 5;
            this.buttonCadastroEstoque.Text = "Cadastro de Estoque";
            this.buttonCadastroEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastroEstoque.UseVisualStyleBackColor = true;
            this.buttonCadastroEstoque.Click += new System.EventHandler(this.buttonCadastroEstoque_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.buttonCadastroEstoque);
            this.Controls.Add(this.buttonCadastrarFarmacia);
            this.Controls.Add(this.buttonCadastroProduto);
            this.Controls.Add(this.buttonTipoProduto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCadastroCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastroCliente;
        private Button button2;
        private Button buttonTipoProduto;
        private Button buttonCadastroProduto;
        private Button buttonCadastrarFarmacia;
        private Button buttonCadastroEstoque;
    }
}