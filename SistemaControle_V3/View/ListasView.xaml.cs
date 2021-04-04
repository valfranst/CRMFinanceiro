using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
