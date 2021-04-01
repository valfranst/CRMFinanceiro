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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyConfig myConfig;
        Resultado result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myConfig = MyConfig._getInstance();

            result = myConfig.checkDb();
            if (result.estado) btReset.Background = Brushes.Green;
            else
            {
                btReset.Background = Brushes.Red;
                MessageBox.Show(result.mensagem, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            ClienteListView clw = new ClienteListView(this);
            Navegador(clw);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        #region

        private void btCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteListView clw = new ClienteListView(this);
            Navegador(clw);
        }

        private void btProducao_Click(object sender, RoutedEventArgs e)
        {
            ProducaoView pw = new ProducaoView(this);
            Navegador(pw);
        }

        private void btRecebimento_Click(object sender, RoutedEventArgs e)
        {
            RecebimentoView rcw = new RecebimentoView(this);
            Navegador(rcw);
        }

        private void btRefinanciamento_Click(object sender, RoutedEventArgs e)
        {
            RefinanciamentoView rfw = new RefinanciamentoView(this);
            Navegador(rfw);
        }

        private void btAddCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteCadastroView cfw = new ClienteCadastroView(this);
            Navegador(cfw);
        }

        private void btExtra_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btConfiguracao_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion


        public void Navegador(UIElement tela)
        {
            if (tela is null) MessageBox.Show("Planilha não encontrada, não foi possível mudar a tela!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                GridMain.Children.Clear();
                GridMain.Children.Add(tela);

            }
        }

        private void txtPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Navegador(clientePesquisa);
            //clientePesquisa.FiltroPesquisa(txtPesquisa.Text);
        }
        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            result = myConfig.IniciarEstrutura();
            if (!result.estado)
            {
                MessageBox.Show(result.mensagem, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                btReset.Background = Brushes.Red;
            }
            else btReset.Background = Brushes.Green;
        }


    }//*****************************
}
