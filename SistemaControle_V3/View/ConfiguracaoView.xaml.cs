using System.Windows;
using System.Windows.Controls;

namespace SistemaControle_V3
{
    /// <summary>
    /// Interação lógica para ConfiguracaoView.xam
    /// </summary>
    public partial class ConfiguracaoView : UserControl
    {
        MainWindow mw;

        public ConfiguracaoView(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

    } //************************
}
