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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTipoProduto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCadastrarFarmacia = new System.Windows.Forms.Button();
            this.buttonCadastroEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 125);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonTipoProduto
            // 
            this.buttonTipoProduto.Location = new System.Drawing.Point(315, 44);
            this.buttonTipoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTipoProduto.Name = "buttonTipoProduto";
            this.buttonTipoProduto.Size = new System.Drawing.Size(141, 125);
            this.buttonTipoProduto.TabIndex = 2;
            this.buttonTipoProduto.Text = "Tipo de Produto";
            this.buttonTipoProduto.UseVisualStyleBackColor = true;
            this.buttonTipoProduto.Click += new System.EventHandler(this.buttonTipoProduto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 200);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 113);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarFarmacia
            // 
            this.buttonCadastrarFarmacia.Location = new System.Drawing.Point(163, 200);
            this.buttonCadastrarFarmacia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastrarFarmacia.Name = "buttonCadastrarFarmacia";
            this.buttonCadastrarFarmacia.Size = new System.Drawing.Size(145, 113);
            this.buttonCadastrarFarmacia.TabIndex = 4;
            this.buttonCadastrarFarmacia.Text = "Cadastro de Farmacia";
            this.buttonCadastrarFarmacia.UseVisualStyleBackColor = true;
            this.buttonCadastrarFarmacia.Click += new System.EventHandler(this.buttonCadastrarFarmacia_Click);
            // 
            // buttonCadastroEstoque
            // 
            this.buttonCadastroEstoque.Location = new System.Drawing.Point(315, 200);
            this.buttonCadastroEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastroEstoque.Name = "buttonCadastroEstoque";
            this.buttonCadastroEstoque.Size = new System.Drawing.Size(141, 113);
            this.buttonCadastroEstoque.TabIndex = 5;
            this.buttonCadastroEstoque.Text = "Cadastro de Estoque";
            this.buttonCadastroEstoque.UseVisualStyleBackColor = true;
            this.buttonCadastroEstoque.Click += new System.EventHandler(this.buttonCadastroEstoque_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 337);
            this.Controls.Add(this.buttonCadastroEstoque);
            this.Controls.Add(this.buttonCadastrarFarmacia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTipoProduto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button buttonTipoProduto;
        private Button button4;
        private Button buttonCadastrarFarmacia;
        private Button buttonCadastroEstoque;
    }
}