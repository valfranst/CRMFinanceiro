using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SistemaControle_V3
{
    public partial class ClienteListView : UserControl
    {
        MainWindow mw;

        public ClienteListView(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ClienteModel clienteModel = new();
            var retorno = clienteModel.GetAll();
            Resultado resultado = retorno.Item1;
            if (resultado.estado) DG_ClienteList.ItemsSource = retorno.Item2;
            else MessageBox.Show(resultado.mensagem);

            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#373737")); //
        }

        public void FiltroPesquisa(string pesquisa)
        {
            try
            {
                if (pesquisa.Length > 0 && DG_ClienteList.ItemsSource != null)
                {
                    DG_ClienteList.ClearFilters();
                    DG_ClienteList.Columns["Pesquisa"].FilterPredicates.Add(new FilterPredicate()
                    {
                        FilterType = FilterType.Contains,
                        FilterValue = pesquisa,
                        FilterBehavior = FilterBehavior.StringTyped,
                        FilterMode = ColumnFilter.Value,
                        PredicateType = PredicateType.AndAlso,
                        IsCaseSensitive = true
                    });
                    DG_ClienteList.View.RefreshFilter();
                }
                else DG_ClienteList.ClearFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar! \n\n" + ex);
            }
        }
        public void AtualizarDados()
        {
            ClienteModel clienteModel = new();
            DG_ClienteList.ItemsSource = clienteModel.GetAll().Item2;

            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#373737")); //
            bt36.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt69.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt912.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt12Mais.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
        }

        public void Inativos(int opcao)
        {
            ClienteModel clienteModel = new();
            var retorno = clienteModel.GetAll(opcao);
            Resultado resultado = retorno.Item1;
            if (resultado.estado)
            {
                mw.txtPesquisa.Text = null;
                DG_ClienteList.ItemsSource = retorno.Item2;
            }
            else MessageBox.Show(resultado.mensagem);
        }



        private void bt_ClienteCadastro_Click(object sender, RoutedEventArgs e)
        {
            var row = DG_ClienteList.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ViewListCliente cli = (ViewListCliente)row;
                ClienteCadastroView cliView = new(mw, cli.IdCliente);
                mw.Navegador(cliView);
            }
        }

        private void bt_ClienteFicha_Click(object sender, RoutedEventArgs e)
        {
            var row = DG_ClienteList.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ViewListCliente cli = (ViewListCliente)row;
                ClienteFichaView empView = new(mw, cli.IdCliente);
                mw.Navegador(empView);
            }
        }

        private void DG_ClienteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var visualcontainer = this.DG_ClienteList.GetVisualContainer();
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            if (rowColumnIndex.IsEmpty) return;

            var row = DG_ClienteList.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ViewListCliente cli = (ViewListCliente)row;
                ClienteFichaView empView = new(mw, cli.IdCliente);
                mw.Navegador(empView);
            }
        }



        private void bt36_Click(object sender, RoutedEventArgs e)
        {
            Inativos(1);
            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt36.Background = (Brush)(new BrushConverter().ConvertFrom("#373737")); //
            bt69.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));  
            bt912.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt12Mais.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
        }

        private void bt69_Click(object sender, RoutedEventArgs e)
        {
            Inativos(2);
            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt36.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5")); 
            bt69.Background = (Brush)(new BrushConverter().ConvertFrom("#373737")); //
            bt912.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt12Mais.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
        }

        private void bt912_Click(object sender, RoutedEventArgs e)
        {
            Inativos(3);
            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt36.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5")); 
            bt69.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt912.Background = (Brush)(new BrushConverter().ConvertFrom("#373737"));  //
            bt12Mais.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
        }

        private void bt12Mais_Click(object sender, RoutedEventArgs e)
        {
            Inativos(4);
            btAll.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt36.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5")); 
            bt69.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt912.Background = (Brush)(new BrushConverter().ConvertFrom("#FF3F51B5"));
            bt12Mais.Background = (Brush)(new BrushConverter().ConvertFrom("#373737"));  //
        }

        private void btAll_Click(object sender, RoutedEventArgs e)
        {
            AtualizarDados();              
        }

    } //************************
}
