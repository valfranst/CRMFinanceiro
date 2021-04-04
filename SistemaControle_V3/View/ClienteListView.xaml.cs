using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ClienteModel clienteModel = new ClienteModel();
            var retorno = clienteModel.GetAll();
            Resultado resultado = retorno.Item1;
            if (resultado.estado) DG_ClienteList.ItemsSource = retorno.Item2;
            else MessageBox.Show(resultado.mensagem);
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
            ClienteModel clienteModel = new ClienteModel();
            DG_ClienteList.ItemsSource = clienteModel.GetAll().Item2;
        }



        private void bt_ClienteCadastro_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroView ccw = new ClienteCadastroView(mw, 0);
            mw.Navegador(ccw);

            //var row = DG_ClienteView.SelectedItem;
            //if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            //else
            //{
            //    Cliente cli = (Cliente)row;
            //    ClienteView cliView = new ClienteView(mw, cli.IdCliente);
            //    mw.Navegador(cliView);
            //}

        }

        private void bt_ClienteFicha_Click(object sender, RoutedEventArgs e)
        {
            ClienteFichaView cfw = new ClienteFichaView(mw, 0);
            mw.Navegador(cfw);

            //var row = DG_ClienteView.SelectedItem;
            //if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            //else
            //{
            //    Cliente cli = (Cliente)row;
            //    EmpView empView = new EmpView(mw, cli.IdCliente);
            //    mw.Navegador(empView);
            //}

        }

        private void DG_ClienteList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var visualcontainer = this.DG_ClienteView.GetVisualContainer(); 
            //var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            //if (rowColumnIndex.IsEmpty) return;

            //var row = DG_ClienteView.SelectedItem;
            //if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            //else
            //{
            //    Cliente cli = (Cliente)row;
            //    EmpView empView = new EmpView(mw, cli.IdCliente);
            //    mw.Navegador(empView);
            //}
        }
    } //************************
}
