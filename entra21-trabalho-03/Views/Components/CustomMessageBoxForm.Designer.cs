namespace entra21_trabalho_03.Views.Components
{
    partial class CustomMessageBoxForm
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
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxContent
            // 
            this.pictureBoxContent.Image = global::entra21_trabalho_03.Properties.Resources.error;
            this.pictureBoxContent.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(124, 142);
            this.pictureBoxContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxContent.TabIndex = 0;
            this.pictureBoxContent.TabStop = false;
            // 
            // labelContent
            // 
            this.labelContent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContent.Location = new System.Drawing.Point(142, 42);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelContent.Size = new System.Drawing.Size(461, 100);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Content";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(482, 188);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(179, 68);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // CustomMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 261);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.pictureBoxContent);
            this.Name = "CustomMessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxContent;
        private Label labelContent;
        private Button buttonOk;
    }
}