namespace entra21_trabalho_03.Views.Profissoes
{
    partial class ProfissaoListagemForm
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadatrar = new System.Windows.Forms.Button();
            this.dataGridViewProfissoes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(96, 25);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(177, 25);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadatrar
            // 
            this.buttonCadatrar.Location = new System.Drawing.Point(258, 25);
            this.buttonCadatrar.Name = "buttonCadatrar";
            this.buttonCadatrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadatrar.TabIndex = 2;
            this.buttonCadatrar.Text = "Cadastrar";
            this.buttonCadatrar.UseVisualStyleBackColor = true;
            this.buttonCadatrar.Click += new System.EventHandler(this.buttonCadatrar_Click);
            // 
            // dataGridViewProfissoes
            // 
            this.dataGridViewProfissoes.AllowUserToAddRows = false;
            this.dataGridViewProfissoes.AllowUserToDeleteRows = false;
            this.dataGridViewProfissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCargo});
            this.dataGridViewProfissoes.Location = new System.Drawing.Point(23, 65);
            this.dataGridViewProfissoes.Name = "dataGridViewProfissoes";
            this.dataGridViewProfissoes.ReadOnly = true;
            this.dataGridViewProfissoes.RowTemplate.Height = 25;
            this.dataGridViewProfissoes.Size = new System.Drawing.Size(310, 231);
            this.dataGridViewProfissoes.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ProfissaoListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 335);
            this.Controls.Add(this.dataGridViewProfissoes);
            this.Controls.Add(this.buttonCadatrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "ProfissaoListagemForm";
            this.Text = "Listagem de Profissões";
            this.Load += new System.EventHandler(this.ProfissaoListagemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfissoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadatrar;
        private DataGridView dataGridViewProfissoes;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCargo;
    }
}