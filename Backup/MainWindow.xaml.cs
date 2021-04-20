using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows;

namespace Backup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string remetente = null;
        string destino = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\Aplicativo\Banco\Represa04.mdf")) remetente = @"C:\Aplicativo";
                else if (File.Exists(@"D:\Aplicativo\Banco\Represa04.mdf")) remetente = @"D:\Aplicativo";
                else if (File.Exists(@"E:\Aplicativo\Banco\Represa04.mdf")) remetente = @"E:\Aplicativo";
                else if (File.Exists(@"F:\Aplicativo\Banco\Represa04.mdf")) remetente = @"F:\Aplicativo";
                else if (File.Exists(@"G:\Aplicativo\Banco\Represa04.mdf")) remetente = @"G:\Aplicativo";
                else if (File.Exists(@"H:\Aplicativo\Banco\Represa04.mdf")) remetente = @"H:\Aplicativo";
                else return;
                getDadosRemetente();
            }
            catch (Exception ex) { MessageBox.Show("Erro!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
            
        }


        public void iniciar()
        {
            ProgressDialog pg = new ProgressDialog();
            try
            {
                if(destino is null)
                {
                    MessageBox.Show("Erro!\n\nSelecione uma pasta para salvar o Backup...", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!Directory.Exists(remetente))
                {
                    MessageBox.Show("Erro!\n\nA pasta do Banco de Dados não foi encontrada...", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!Directory.Exists(remetente + @"\Imagens"))
                {
                    MessageBox.Show("Erro!\n\nA pasta Imagens dos Clientes não foi encontrada...", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!File.Exists(remetente + @"\Banco\Represa04.mdf"))
                {
                    MessageBox.Show("Erro!\n\nO arquivo .MDF do Banco de Dados não foi encontrado...", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!File.Exists(remetente + @"\Banco\Represa04_log.ldf"))
                {
                    MessageBox.Show("Erro!\n\nO arquivo .LDF do Banco de Dados não foi encontrado...", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                
                pg.Show();
                string nome = @"/Backup_" + DateTime.Now.ToString("dd-MM-yyyy_HHmmss") + ".zip";
                string saida = destino + "" + nome;
                ZipFile.CreateFromDirectory(remetente, saida);
                txtDestinatario.Text += "\nArquivo Gerado: " + nome.Replace("/","");
                FileInfo fileDestino = new FileInfo(saida);
                txtDestinatario.Text += "\nTamanho do arquivo Gerado: " + ByteTo(fileDestino.Length);
                pg.Close();
            }
            catch (Exception ex) { Console.WriteLine("ERRO!\n\n" + ex); }
            finally { pg.Close();  }
        }

        private void btRemetente(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Selecione a pasta";
                if (folderBrowser.ShowDialog() == true)
                {
                    remetente = Path.GetDirectoryName(folderBrowser.FileName);
                    getDadosRemetente();
                }
                else MessageBox.Show("Erro!\n\n" + "Você cancelou a escolha da pasta para salvaro Backup!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);                  
            }
            catch (Exception ex) {  MessageBox.Show("Backup não realizado!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void btDestinatario(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Selecione a pasta";
                if (folderBrowser.ShowDialog() == true)
                {
                    destino = Path.GetDirectoryName(folderBrowser.FileName);
                    txtDestinatario.Text += "\nEndereço de Destino: " + destino;
                }
                else MessageBox.Show("Erro!\n\n" + "Você cancelou a escolha da pasta para salvaro Backup!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Backup não realizado!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void btIniciar(object sender, RoutedEventArgs e)
        {
            iniciar();
        }


        public void getDadosRemetente()
        {
            try
            {     
                FileInfo db = new FileInfo(remetente + @"\Banco\Represa04.mdf");
                FileInfo log = new FileInfo(remetente + @"\Banco\Represa04_log.ldf");
                DirectoryInfo pasta = new DirectoryInfo(remetente);

                txtRemetente.Text += "\nPasta do Sistema: " + remetente;
                txtRemetente.Text += "\nTamanho da Pasta do SISTEMA: " + ByteTo(DirSize(pasta));
                txtRemetente.Text += "\nTamanho arquivo Banco de Dados: " + ByteTo(db.Length);
                txtRemetente.Text += "\nTamanho arquivo LOG Banco de Dados: " + ByteTo(log.Length);
                txtRemetente.Text += "\nQuantidade de imagem salvas:  " + Directory.GetFiles(remetente + @"\Imagens", "*", SearchOption.TopDirectoryOnly).Length;
            }
            catch (Exception ex) { MessageBox.Show("Erro!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }


        public string ByteTo(long value)
        {
            string retorno = null;
            if (value / 1024 == 0)
            {
                retorno = value + " bytes";
            }
            else if (value / (1024 * 1024) == 0)
            {
                retorno = string.Format("{0:n1} KB", value / 1024f);
            }
            else if (value / (1024 * 1024 * 1024) == 0)
            {
                retorno = string.Format("{0:n1} MB", value / 1024f);
            }

            return retorno;
        }
        public long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }


    }//*****************
}
