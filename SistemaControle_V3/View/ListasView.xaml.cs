using System.Windows;
using System.Windows.Controls;

namespace SistemaControle_V3
{
    /// <summary>
    /// Interação lógica para ListasView.xam
    /// </summary>
    public partial class ListasView : UserControl
    {
        MainWindow mw;

        public ListasView(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

    } //************************
}
