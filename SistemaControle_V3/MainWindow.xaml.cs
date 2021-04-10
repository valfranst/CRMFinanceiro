using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SistemaControle_V3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyConfig myConfig;
        Resultado result;
        public ClienteListView clienteList = null;
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
            clienteList = new ClienteListView(this);
            Navegador(clienteList);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        #region

        private void btCliente_Click(object sender, RoutedEventArgs e)
        {
            txtPesquisa.Text = "";
            clienteList = new ClienteListView(this);
            Navegador(clienteList);
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
            ClienteCadastroView cfw = new ClienteCadastroView(this, 0);
            Navegador(cfw);
        }

        private void btExtra_Click(object sender, RoutedEventArgs e)
        {
            //ListasView lw = new ListasView(this);
            //Navegador(lw);
        }

        private void btConfiguracao_Click(object sender, RoutedEventArgs e)
        {
            //ConfiguracaoView cow = new ConfiguracaoView(this);
            //Navegador(cow);
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

        private async void txtPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            await Task.Delay(2000);
            if (!GridMain.Children.Contains(clienteList)) Navegador(clienteList);
            clienteList.FiltroPesquisa(txtPesquisa.Text);
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

        private void btUpload_Click(object sender, RoutedEventArgs e)
        {
            result = myConfig.BackupDados();
            if (result.estado) MessageBox.Show("Backup concluido com sucesso!", "CONCLUIDO", MessageBoxButton.OK, MessageBoxImage.Information);
            else MessageBox.Show(result.mensagem, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }//*****************************
}
