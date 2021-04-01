using SistemaControle.Arquitetura;
using SistemaControle.View;
using Syncfusion.SfSkinManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SistemaControle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MyConfig myConfig;
        Resultado result;
        List<UIElement> telas = new List<UIElement>();
        string penDriver = null;

        public ClientePesquisa clientePesquisa;
        ClienteView clienteView;
        Configuracao configuracao;
        Producao producao;
        Recebimento recebimento;
        Refinanciamento refinanciamento;
        ListasExtra listasExtra;


        public MainWindow()
        {
            InitializeComponent();
        } 
        
        public void SetTheme(string theme)
        {
            SfSkinManager.SetTheme(this, new Theme(theme));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   
            GridMain.Height = (this.Height - 43);
            GridMain.Width = this.Width - 10;
            myConfig = MyConfig._getInstance();

            result = myConfig.checkDb();
            if (result.estado) btReset.Background = Brushes.Green;
            else
            {
                btReset.Background = Brushes.Red;
                MessageBox.Show(result.mensagem, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (File.Exists(myConfig.Local + @"\exportar.json"))
            {
                btUpload.Background = Brushes.Red;
                btUpload.IsEnabled = true;
            }
            

            clientePesquisa = new ClientePesquisa(this);
            GridMain.Children.Clear();
            Navegador(clientePesquisa);

        }        

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        public void Navegador(UIElement tela)
        {
            if(tela is null) MessageBox.Show("Planilha não encontrada, não foi possível mudar a tela!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);              
            else
            {
                GridMain.Children.Clear();
                GridMain.Children.Add(tela);
                telas.Add(tela);
                
            }
        }
       
        private void txtPesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            Navegador(clientePesquisa);
            clientePesquisa.FiltroPesquisa(txtPesquisa.Text);
        }
                                                                                             

        #region Butoes menu         
               
        private void btExtra_Click(object sender, RoutedEventArgs e)
        {
            if (listasExtra == null) listasExtra = new ListasExtra(this);
            Navegador(listasExtra);
        }

        private void btConfiguracao_Click(object sender, RoutedEventArgs e)
        {
            if (configuracao == null) configuracao = new Configuracao(this);
            Navegador(configuracao);
        }

        


        //***********************************************************************************

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

        private void btAddCliente_Click(object sender, RoutedEventArgs e)
        {
            if (clienteView == null) clienteView = new ClienteView(this, 0);
            Navegador(clienteView);
        }

        private void btRefinanciamento_Click(object sender, RoutedEventArgs e)
        {
            if (refinanciamento == null) refinanciamento = new Refinanciamento(this);
            Navegador(refinanciamento);
        }

        private void btRecebimento_Click(object sender, RoutedEventArgs e)
        {
            if (recebimento == null) recebimento = new Recebimento(this);
            Navegador(recebimento);
        }

        private void btProducao_Click(object sender, RoutedEventArgs e)
        {
            if (producao == null) producao = new Producao(this);
            Navegador(producao);
        }

        private void btCliente_Click(object sender, RoutedEventArgs e)
        {               
            if(clientePesquisa == null) clientePesquisa = new ClientePesquisa(this);
            Navegador(clientePesquisa);
            txtPesquisa.Text = "";
        }


        #endregion

        private void btUpload_Click(object sender, RoutedEventArgs e)
        {
            ProgressDialog pd = new ProgressDialog();
            pd.Show();

            if (IsConnected() == 0)
            {

                if (txtPemDriver.Content.ToString() == "Nulo")
                {
                    MessageBox.Show("Por favor, antes de continuar, selecione entre 'ESCRITORIO' e 'CASA' na barra de menu.", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    pd.Close();
                    return;
                }

                FireNet fire = new FireNet(this);
                result = Resultado.Ok();
                List<Espelho> espelhos = null;

                bool verifica = File.Exists(myConfig.Local + @"\exportar.json"); 

                if(!verifica)
                {
                    MessageBox.Show("Sem dados para salvar na Nuvem.", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    File.Delete(myConfig.Local + @"\exportar.json");
                    btUpload.Background = Brushes.Cyan;
                }
                else
                {
                    espelhos = fire.getFileJson();
                    Resultado result = fire.InserirPonte(espelhos); 
                    if (result.estado)
                    {
                        if (File.Exists(myConfig.Local + @"\exportar.json"))
                        {
                            File.Delete(myConfig.Local + @"\exportar.json");
                            btUpload.Background = Brushes.Cyan;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar dados na nuvem.\n" + result.mensagem, "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        Clipboard.SetText(result.mensagem);
                    }
                }      
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar. Por favor verifique/reestabeleça a conexão com a INTERNET.", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            pd.Close();
        }

        private void btDownload_Click(object sender, RoutedEventArgs e)
        {
            ProgressDialog pd = new ProgressDialog();
            pd.Show();

            if (IsConnected() == 0)
            {

                if (txtPemDriver.Content.ToString() == "Nulo")
                {
                    MessageBox.Show("Por favor, antes de continuar, selecione entre 'ESCRITORIO' e 'CASA' na barra de menu.", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    pd.Close();
                    return;
                }

                FireNet fire = new FireNet(this);
                Resultado result = fire.BaixarPonteAsync();
                if (result.estado is true)
                {
                    fire.ExcluirPonte();
                }

            }
            else
            {
                MessageBox.Show("Não foi possível se conectar. Por favor verifique/reestabeleça a conexão com a INTERNET.", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            pd.Close();
        }

        public static int IsConnected()
        {
            int fail;

            System.Uri Url = new System.Uri("http://www.microsoft.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                fail = 0; //consegue conexão à internet
                return fail;
            }

            catch(System.Net.WebException)
            {
                WebReq = null;
                fail = 1; //falhou a conexão à internet
                return fail;
            }
            catch
            {
                WebReq = null;
                fail = 1; //falhou a conexão à internet
                return fail;
            }
        }

        private void btPenDriver_Click(object sender, RoutedEventArgs e)
        {
            if (btPenDriver.IsChecked == true) txtPemDriver.Content = "Escritorio";
            if (btPenDriver.IsChecked == false) txtPemDriver.Content = "Casa";
        }

        private void btEndereco_Click(object sender, RoutedEventArgs e)
        {
            myConfig.AtualizarEndereco();
        }
    }   //Fim class
}
