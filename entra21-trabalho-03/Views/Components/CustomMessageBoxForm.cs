﻿using entra21_trabalho_03.Enums;

namespace entra21_trabalho_03.Views.Components
{
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm(MessageBoxType messageBoxType, string content)
        {
            InitializeComponent();

            labelContent.Text = content.Trim();

            DefinirImagem(messageBoxType);
        }

        private void DefinirImagem(MessageBoxType messageBoxType)
        {
            if (messageBoxType == MessageBoxType.Error)
                pictureBoxContent.Image = Properties.Resources.error;
            else if (messageBoxType == MessageBoxType.Warning)
                pictureBoxContent.Image = Properties.Resources.warning;
            else if (messageBoxType == MessageBoxType.Success)
                pictureBoxContent.Image = Properties.Resources.success;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
