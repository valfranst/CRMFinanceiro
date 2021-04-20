using System.Windows;

namespace Backup
{
    /// <summary>
    /// Lógica interna para ProgressDialog.xaml
    /// </summary>
    public partial class ProgressDialog : Window
    {
        public ProgressDialog()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
