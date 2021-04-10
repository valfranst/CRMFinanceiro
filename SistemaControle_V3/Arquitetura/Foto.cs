using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;

namespace SistemaControle_V3
{
    public class Foto
    {
        static MyConfig myConfig = MyConfig._getInstance();
        static DirectoryInfo dir = new DirectoryInfo(myConfig.Imagem);
        static FileInfo[] files;


        public Foto() { }

        public static Resultado ExcluirImagem(string nomeCliente)
        {
            try
            {
                files = dir.GetFiles(nomeCliente + ".*");
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
                return Resultado.Ok();
            }
            catch (Exception ex)
            {
                return Resultado.Erro("Erro ao EXCLUIR a imagem do Cliente: " + nomeCliente + "\n\n" + ex);
            }
        }

        public static (Resultado, BitmapImage) GetImagemByNome(string nomeCliente)
        {
            try
            {
                FileInfo[] files = dir.GetFiles(nomeCliente + ".*");
                if (files.Count() > 0)
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(files[0].FullName);
                    bitmap.DecodePixelWidth = 250;
                    bitmap.DecodePixelHeight = 250;
                    bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    return (Resultado.Ok(), bitmap);
                }
                else return (Resultado.Ok(), null);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao Carregar Imagem do Cliente\n\n!" + ex, "ATENCAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Error);
                return (Resultado.Ok(), null);
            }
        }

        public static Resultado SalvarImagemByNome(BitmapImage foto, string nomeCliente)
        {
            try
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)foto));
                ExcluirImagem(nomeCliente);
                using (FileStream stream = new FileStream(myConfig.Imagem + @"\" + nomeCliente + ".jpg", FileMode.Create)) encoder.Save(stream);
                return Resultado.Ok();
            }
            catch (Exception ex) { return Resultado.Erro("Erro ao Salvar Imagem! \n\n" + ex); }
        }

        public static Resultado RenomearImagem(string nomeNovo, string nomeAntigo)
        {
            try
            {
                files = dir.GetFiles(nomeAntigo + ".*");
                if (files.Count() > 1)
                {
                    var maxData = DateTime.MinValue;
                    FileInfo atual = null;
                    foreach (FileInfo file in files)
                    {
                        if (file.CreationTime > maxData)
                        {
                            atual = file;
                            maxData = file.CreationTime;
                        }
                        else file.Delete();
                    }
                }
                files = dir.GetFiles(nomeAntigo + ".*");
                FileInfo antigo = files[0];
                File.Move(antigo.FullName, myConfig.Imagem + @"\" + nomeNovo + antigo.Extension);
                return Resultado.Ok();
            }
            catch (Exception ex) { return Resultado.Erro("Erro, ao Renomear a imagem do Cliente. Por favor, verifique sua existência." + "\n\n" + ex); }
        }

        public static (Resultado, BitmapImage) CopiarArquivo(string nomeCliente)
        {
            try
            {
                string arquivoSelecionado = "";
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                folderBrowser.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                // Always default to Folder Selection.
                folderBrowser.FileName = "Selecione a pasta";
                if (folderBrowser.ShowDialog() == true)
                {
                    arquivoSelecionado = folderBrowser.FileName;
                    FileInfo fi = new FileInfo(arquivoSelecionado);
                    ExcluirImagem(nomeCliente);
                    File.Copy(fi.FullName, myConfig.Imagem + @"\" + nomeCliente + fi.Extension, true);
                    return (Resultado.Ok(), GetImagemByNome(nomeCliente).Item2);
                }
                return (Resultado.Erro("Não foram feitas alterações na Imagem do Cliente"), null);
            }
            catch (Exception ex) { return (Resultado.Erro("Error\n\n" + ex), null); }
        }


    }//Fim Class
}
