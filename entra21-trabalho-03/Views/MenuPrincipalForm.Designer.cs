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
            this.buttonCadastroProfissao = new System.Windows.Forms.Button();
            this.buttonTipoProduto = new System.Windows.Forms.Button();
            this.buttonCadastroProduto = new System.Windows.Forms.Button();
            this.buttonCadastrarDistribuidora = new System.Windows.Forms.Button();
            this.buttonCadastroEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroCliente
            // 
            this.buttonCadastroCliente.Location = new System.Drawing.Point(14, 33);
            this.buttonCadastroCliente.Name = "buttonCadastroCliente";
            this.buttonCadastroCliente.Size = new System.Drawing.Size(161, 113);
            this.buttonCadastroCliente.TabIndex = 0;
            this.buttonCadastroCliente.Text = "Cadastro de Cliente";
            this.buttonCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCadastroCliente.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // buttonCadastroProfissao
            // 
            this.buttonCadastroProfissao.Location = new System.Drawing.Point(197, 33);
            this.buttonCadastroProfissao.Name = "buttonCadastroProfissao";
            this.buttonCadastroProfissao.Size = new System.Drawing.Size(161, 113);
            this.buttonCadastroProfissao.TabIndex = 1;
            this.buttonCadastroProfissao.Text = "Cadastrar Profissões";
            this.buttonCadastroProfissao.UseVisualStyleBackColor = true;
            this.buttonCadastroProfissao.Click += new System.EventHandler(this.buttonCadastroProfissao_Click);
            // 
            // buttonTipoProduto
            // 
            this.buttonTipoProduto.Location = new System.Drawing.Point(377, 33);
            this.buttonTipoProduto.Name = "buttonTipoProduto";
            this.buttonTipoProduto.Size = new System.Drawing.Size(161, 113);
            this.buttonTipoProduto.TabIndex = 2;
            this.buttonTipoProduto.Text = "Cadastro de Tipo de Produto";
            this.buttonTipoProduto.UseVisualStyleBackColor = true;
            this.buttonTipoProduto.Click += new System.EventHandler(this.buttonTipoProduto_Click);
            // 
            // buttonCadastroProduto
            // 
            this.buttonCadastroProduto.Location = new System.Drawing.Point(14, 178);
            this.buttonCadastroProduto.Name = "buttonCadastroProduto";
            this.buttonCadastroProduto.Size = new System.Drawing.Size(161, 113);
            this.buttonCadastroProduto.TabIndex = 3;
            this.buttonCadastroProduto.Text = "Cadastro de Produtos";
            this.buttonCadastroProduto.UseVisualStyleBackColor = true;
            this.buttonCadastroProduto.Click += new System.EventHandler(this.buttonCadastroProduto_Click);
            // 
            // buttonCadastrarDistribuidora
            // 
            this.buttonCadastrarDistribuidora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarDistribuidora.Image = global::entra21_trabalho_03.Properties.Resources.pharmacy;
            this.buttonCadastrarDistribuidora.Location = new System.Drawing.Point(197, 178);
            this.buttonCadastrarDistribuidora.Name = "buttonCadastrarDistribuidora";
            this.buttonCadastrarDistribuidora.Size = new System.Drawing.Size(161, 113);
            this.buttonCadastrarDistribuidora.TabIndex = 4;
            this.buttonCadastrarDistribuidora.Text = "Cadastro de Distribuidora";
            this.buttonCadastrarDistribuidora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastrarDistribuidora.UseVisualStyleBackColor = true;
            this.buttonCadastrarDistribuidora.Click += new System.EventHandler(this.buttonCadastrarDistribuidora_Click);
            // 
            // buttonCadastroEstoque
            // 
            this.buttonCadastroEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastroEstoque.Image = global::entra21_trabalho_03.Properties.Resources.inventory;
            this.buttonCadastroEstoque.Location = new System.Drawing.Point(377, 178);
            this.buttonCadastroEstoque.Name = "buttonCadastroEstoque";
            this.buttonCadastroEstoque.Size = new System.Drawing.Size(161, 113);
            this.buttonCadastroEstoque.TabIndex = 5;
            this.buttonCadastroEstoque.Text = "Cadastro de Estoque";
            this.buttonCadastroEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCadastroEstoque.UseVisualStyleBackColor = true;
            this.buttonCadastroEstoque.Click += new System.EventHandler(this.buttonCadastroEstoque_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 300);
            this.Controls.Add(this.buttonCadastroEstoque);
            this.Controls.Add(this.buttonCadastrarDistribuidora);
            this.Controls.Add(this.buttonCadastroProduto);
            this.Controls.Add(this.buttonTipoProduto);
            this.Controls.Add(this.buttonCadastroProfissao);
            this.Controls.Add(this.buttonCadastroCliente);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCadastroCliente;
        private Button buttonCadastroProfissao;
        private Button buttonTipoProduto;
        private Button buttonCadastroProduto;
        private Button buttonCadastrarDistribuidora;
        private Button buttonCadastroEstoque;
    }
}