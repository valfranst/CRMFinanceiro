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


        public Foto()
        {  
        }

        public static Resultado ExcluirImagem(string nomeCliente)
        {
            try
            {
                //***************************************** passo 01
                DirectoryInfo dir = new DirectoryInfo(myConfig.Imagem);
                FileInfo[] files = dir.GetFiles(nomeCliente + ".*");
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }                  

                //***************************************** passo 02
                dir = new DirectoryInfo(myConfig.ImagemTemp);
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


        //public static BitmapImage GetImagemByNome(string nomeCliente)
        //{
        //    DirectoryInfo dir = new DirectoryInfo(myConfig.Imagem);
        //    FileInfo[] files = dir.GetFiles(nomeCliente + ".*");
        //    if (files.Length > 1)
        //    {
        //        MessageBox.Show("Existe mais de uma Imagem para esse cliente.\n\nPor favor vá até a pasta IMAGENS e apague a mais antiga", "ATENCAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    else if (files.Length == 1)
        //    {
        //        try
        //        {
        //            using (var bmp = new System.Drawing.Bitmap(files[0].FullName))
        //            {
        //            }
        //            BitmapImage bitmap = new BitmapImage();
        //            bitmap.BeginInit();
        //            bitmap.UriSource = new Uri(files[0].FullName);
        //            bitmap.DecodePixelWidth = 250;
        //            bitmap.DecodePixelHeight = 250;
        //            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
        //            bitmap.CacheOption = BitmapCacheOption.OnLoad;
        //            bitmap.EndInit();
        //            return bitmap;
        //        }
        //        catch (Exception ex) 
        //        {                                   
        //            MessageBox.Show("Erro ao Carregar Imagem do Cliente\n\n!" + ex, "ATENCAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Error);
        //            return null;
        //        }
        //    }
        //    return null;
        //}


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
                DirectoryInfo dirImagemTemp = new DirectoryInfo(myConfig.ImagemTemp);
                FileInfo[] filesTemp = dirImagemTemp.GetFiles(nomeAntigo + ".*");
                if (filesTemp.Length > 0)
                {
                    foreach (FileInfo file1 in filesTemp)
                    {
                        file1.Delete();
                    }
                }
                //************************************************

                DirectoryInfo dirImagem = new DirectoryInfo(myConfig.Imagem);
                FileInfo[] filesImagem = dirImagem.GetFiles(nomeAntigo + ".*");
                FileInfo file = null;

                if (filesImagem.Count() == 0)
                {
                    return Resultado.Ok();
                }
                else if (filesImagem.Count() >= 1)
                {
                    file = filesImagem[0];
                    file.CopyTo(myConfig.ImagemTemp+@"\"+nomeAntigo+file.Extension);
                    foreach (FileInfo file2 in filesImagem)
                    {
                        file2.Delete();
                    }
                }

                FileInfo[] filesTemp2 = dirImagemTemp.GetFiles(nomeAntigo + ".*");
                if (filesTemp2.Length > 0)
                {
                    FileInfo temp = filesTemp2[0];
                    File.Move(temp.FullName, myConfig.Imagem + @"\" + nomeNovo + file.Extension);
                }

                return Resultado.Ok();
            }
            catch (Exception ex) { return Resultado.Erro("Erro, ao Renomear a imagem do Cliente. Por favor, verifique sua existência." + "\n\n" + ex); }
        }


    }//Fim Class
}
