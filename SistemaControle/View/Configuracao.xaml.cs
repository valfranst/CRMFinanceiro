using SistemaControle.Arquitetura;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Management;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using SistemaControle.Model;
using System.Linq;

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para MyConfiguracao.xam
    /// </summary>
    public partial class Configuracao : UserControl
    {
        MainWindow mw;
        MyConfig myConfig = MyConfig._getInstance();
        //RepresaContext dc = new RepresaContext();
        public Configuracao(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 53;
            this.Width = mw.Width - 10;
            getWindows();
            getSql();
            getNetF();
            getInfo();
            getResolucao();
            getInfoBanco();
        }

        #region Recuperar informações do sistema
        public void getWindows()
        {
            try
            {
                string so = "";
                string arq = "";
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection information = searcher.Get();
                    if (information != null)
                    {
                        foreach (ManagementObject obj in information)
                        {
                            so = obj["Caption"].ToString();
                            arq = "Arquitetura - " + obj["OSArchitecture"].ToString();
                        }
                    }
                    so = so.Replace("NT 5.1.2600", "XP");
                    so = so.Replace("NT 5.2.3790", "Server 2003");
                    txtSOInfo.Text = so;
                    txtSOStatus.Text = arq;
                    if (so.Contains("NT")) txtSOMsg.Text = "Versão do Windows não pode executar o programa corretamente!";
                }
            }catch
            {
                txtSOInfo.Text = "Versão do Windows não encontrada";
                txtSOInfo.Foreground = Brushes.Red;
                txtSOStatus.Text = "Erro!";
                txtSOMsg.Text = "Erro!!";
            }

        }
        public void getSql()
        {
            try
            {                   
                const string subkey15 = @"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\15.0";
                using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey15))
                {
                    if (ndpKey != null && ndpKey.GetValue("ParentInstance") != null) 
                    {
                        txtSQLInfo.Text = "SQL LocalDB 15"; 
                    }
                    else
                    {
                        txtSQLInfo.Text = "SQL LocalDB 15 não instalado";
                        txtSQLStatus.Text = "Por favor instale o SQL LocalDB versao 15!";
                        txtSQLMsg.Text = "Sem o SQL LocalDB 15 instalado o progama pode não funcionar corretamente!";
                        txtSQLInfo.Foreground = Brushes.Red;
                    }
                }
                const string subkey16 = @"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions\16.0";
                using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey16))
                {
                    if (ndpKey != null && ndpKey.GetValue("ParentInstance") != null)
                    {
                        txtSQLInfo.Text = "SQL LocalDB 16";
                    }
                }

            }
            catch
            {
                txtSQLInfo.Text = "Erro!";
                txtSQLStatus.Text = "Erro!";
                txtSQLMsg.Text = "Sem o SQL LocalDB 15 instalado o progama pode não funcionar corretamente!";
                txtSQLInfo.Foreground = Brushes.Red;
            }
        }
        public void getNetF()
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

            using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    //Console.WriteLine($".NET Framework Version: {CheckFor45PlusVersion((int)ndpKey.GetValue("Release"))}");
                    txtNETInfo.Text = $"{CheckFor45PlusVersion((int)ndpKey.GetValue("Release"))}";
                }
                else
                {
                    txtNETInfo.Text = ".Net Framework 4.7.2 não intalado";
                    txtNETStatus.Text = "Por favor instale o .Net Framework 4.7.2!";
                    txtNETMsg.Text = "Sem o .Net Framework 4.7.2 ou versão superior instalado o progama pode não funcionar corretamente!";
                    txtNETInfo.Foreground = Brushes.Red;
                }
            }            
        }
        string CheckFor45PlusVersion(int releaseKey)
        {
            if (releaseKey >= 528040)
                return ".Net Framework 4.8 ou Superior";
            if (releaseKey >= 461808)
                return ".Net Framework 4.7.2";
            if (releaseKey >= 461308)
                return ".Net Framework 4.7.1";
            if (releaseKey >= 460798)
                return ".Net Framework 4.7";
            if (releaseKey >= 394802)
                return ".Net Framework 4.6.2";
            if (releaseKey >= 394254)
                return ".Net Framework 4.6.1";
            if (releaseKey >= 393295)
                return ".Net Framework 4.6";
            if (releaseKey >= 379893)
                return ".Net Framework 4.5.2";
            if (releaseKey >= 378675)
                return ".Net Framework 4.5.1";
            if (releaseKey >= 378389)
                return ".Net Framework 4.5";
            // This code should never execute. A non-null release key should mean
            // that 4.5 or later is installed.
            return ".Net Framework 4.5 ou superior não encontrada!";
        }


        public void getInfo()
        {
            try
            {
                txtLocal.Text = "RAIZ: " + myConfig.Local;
                txtLocalBanco.Text = "BANCO: " + myConfig.Banco;
                txtLocalImagem.Text = "IMAGENS: " + myConfig.Imagem;
                txtLocalImagemTemp.Text = "IMAGENS TEMP: " + myConfig.ImagemTemp;
                txtDBConexao.Text = "CONNECTION: " + myConfig.Conexao;
                List<string> tamanhos = myConfig.getTamanhoArquivo();
                if (tamanhos.Count > 0)
                {
                    txtDBTamanho.Text = tamanhos[0];
                    txtLOGTamanho.Text = tamanhos[1];
                    txtPastaTamanho.Text = tamanhos[2];
                    txtImagemTamanho.Text = tamanhos[3];
                }
            }
            catch
            {
                txtLocal.Text = "Erro!";
                txtLocalBanco.Text = "Erro!";
                txtLocalImagem.Text = "Erro!";
                txtLocalImagemTemp.Text = "Erro!";
                txtDBConexao.Text = "Erro!";
                txtDBTamanho.Text = "Erro!";
                txtLOGTamanho.Text = "Erro!";
                txtPastaTamanho.Text = "Erro!";
                txtImagemTamanho.Text = "Erro!";
            }
        }
        public void getResolucao()
        {
            Double largura = System.Windows.SystemParameters.PrimaryScreenWidth;
            Double altura = System.Windows.SystemParameters.PrimaryScreenHeight;

            if (largura >= 1200 && altura >= 700)
            {
                txtRESOLUCAOStatus.Text = "Sucesso";
                txtRESOLUCAOMsg.Text = "Resolução da tela => "+largura +" X "+altura;
            }
            else if (largura < 1200 || altura < 700)
            {
                txtRESOLUCAOStatus.Text = "Resolução da Tela imprópria para o Sistema!";
                txtRESOLUCAOMsg.Text = "Resolução atual da tela => " + largura + " X " + altura+"\n A Resolução mínima para um bom funcionamento é de 1200 X 700";
            }
        }
        public void getInfoBanco()
        {
            using (RepresaContext dc = new RepresaContext())
            {
                IEnumerable<Cliente> clientes = dc.Clientes.OrderByDescending(p => p.DataCadastro).Take(5);
                foreach (var cli in clientes)
                {
                    txtCliente.Text += "\n" + cli.NomeClienteNormalizado;
                }

                IEnumerable<Emprestimo> emprestimos = dc.Emprestimos.OrderByDescending(p => p.DataCadastro).Take(5);
                foreach (var emp in emprestimos)
                {
                    txtEmprestimo.Text += "\n " + emp.CodEmprestimo;
                }

                txtClienteCount.Text += " " + dc.Clientes.Select(cli => cli.IdCliente).Count();
            }


            


        }

        #endregion Recuperar informações do sistema


    } //Fim Class
}
