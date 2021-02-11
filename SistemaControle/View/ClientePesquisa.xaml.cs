using SistemaControle.Arquitetura;
using SistemaControle.Model;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para ClientePesquisa.xam
    /// </summary>
    public partial class ClientePesquisa : UserControl
    {
        MainWindow mw;
        //RepresaContext dc = new RepresaContext();
        public ClientePesquisa(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow; 
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.GridMain.Height;
            this.Width = mw.GridMain.Width;
            DG_ClienteView.MaxHeight = this.Height - 55;
            DG_ClienteView.MaxWidth = this.Width;

            using (RepresaContext dc = new RepresaContext())
            {
                DG_ClienteView.ItemsSource = dc.Clientes.ToList();
            }
            
        }

        public void FiltroPesquisa(string pesquisa)
        {
            if (pesquisa.Length > 0)
            {
                DG_ClienteView.ClearFilters();
                DG_ClienteView.Columns["Pesquisa"].FilterPredicates.Add(new FilterPredicate()
                 {
                    FilterType = FilterType.Contains,
                    FilterValue = pesquisa,
                    FilterBehavior = FilterBehavior.StringTyped,
                    FilterMode = ColumnFilter.Value,
                    PredicateType = PredicateType.AndAlso,
                    IsCaseSensitive = true
                });
                DG_ClienteView.View.RefreshFilter();
            }
            else DG_ClienteView.ClearFilters();
        }  

        public void AtualizarDados()
        {
            using (RepresaContext dc = new RepresaContext())
            {
                DG_ClienteView.ItemsSource = dc.Clientes.ToList();
            }
        }
        private void DG_ClienteView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var visualcontainer = this.DG_ClienteView.GetVisualContainer();
            // get the row and column index based on the pointer position 
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            if (rowColumnIndex.IsEmpty) return;

            var row = DG_ClienteView.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                Cliente cli = (Cliente)row;
                EmpView empView = new EmpView(mw, cli.IdCliente);
                mw.Navegador(empView);
            }
        }

        private void bt_ClienteCadastro_Click(object sender, RoutedEventArgs e)
        {
            var row = DG_ClienteView.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                Cliente cli = (Cliente)row;
                ClienteView cliView = new ClienteView(mw, cli.IdCliente);
                mw.Navegador(cliView);
            }
        }

        private void bt_ClienteFicha_Click(object sender, RoutedEventArgs e)
        {
            var row = DG_ClienteView.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                Cliente cli = (Cliente)row;
                EmpView empView = new EmpView(mw, cli.IdCliente);
                mw.Navegador(empView);
            }
        }




    } //Fim Class
}
