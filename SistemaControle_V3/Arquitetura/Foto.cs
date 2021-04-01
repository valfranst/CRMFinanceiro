using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SistemaControle_V3
{
    public class Foto
    {           
        static MyConfig myConfig = MyConfig._getInstance();
        static DirectoryInfo dir = new DirectoryInfo(myConfig.Imagem);
        static FileInfo[] files;


        public Foto(){ }

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

        public static BitmapImage GetImagemByNome(string nomeCliente)
        {
            try
            {
                FileInfo[] files = dir.GetFiles(nomeCliente + ".*");
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(files[0].FullName);
                bitmap.DecodePixelWidth = 250;
                bitmap.DecodePixelHeight = 250;
                bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                return bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar Imagem do Cliente\n\n!" + ex, "ATENCAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
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


    }//Fim Class
}
