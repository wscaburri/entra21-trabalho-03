using entra21_trabalho_03.Enums;

namespace entra21_trabalho_03.Views.Components
{
    public static class CustomMessageBox
    {
        public static void ShowSuccess(string texto)
        {
            ShowMessage(MessageBoxType.Success, texto);
        }

        public static void ShowError(string texto)
        {
            ShowMessage(MessageBoxType.Error, texto);
        }

        public static void ShowWarning(string texto)
        {
            ShowMessage(MessageBoxType.Warning, texto);
        }

        private static void ShowMessage(MessageBoxType messageBoxType, string texto)
        {
            new CustomMessageBoxForm(messageBoxType, texto).ShowDialog();
        }
    }
}
