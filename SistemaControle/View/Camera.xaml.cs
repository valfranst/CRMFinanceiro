
using AForge.Video;
using AForge.Video.DirectShow;
using SistemaControle.Arquitetura;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SistemaControle.View
{
    /// <summary>
    /// Lógica interna para Camera.xaml
    /// </summary>
    public partial class Camera : Window
    {

        VideoCaptureDevice LocalWebCam;
        public FilterInfoCollection LoaclWebCamsCollection;

        ClienteView cv = null;
        private string nomeCliente = null;
        MyConfig myConfig = MyConfig._getInstance();

        public Camera(ClienteView cv, string nomeCliente)
        {
            InitializeComponent();
            this.cv = cv;
            this.nomeCliente = nomeCliente;
            Loaded += Window_Loaded;            
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoaclWebCamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            LocalWebCam = new VideoCaptureDevice(LoaclWebCamsCollection[0].MonikerString);
            LocalWebCam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);

            LocalWebCam.Start();
        }



        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {

                BitmapImage bi;
                using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    bi = new BitmapImage();
                    bi.BeginInit();
                    MemoryStream ms = new MemoryStream();
                    bitmap.Save(ms, ImageFormat.Bmp);
                    ms.Seek(0, SeekOrigin.Begin);
                    bi.StreamSource = ms;
                    bi.CacheOption = BitmapCacheOption.OnLoad;
                    bi.EndInit();
                }
                bi.Freeze();
                Dispatcher.BeginInvoke(new ThreadStart(delegate { frameHolder.Source = bi; }));







                //System.Drawing.Image img = (Bitmap)eventArgs.Frame.Clone();

                //MemoryStream ms = new MemoryStream();
                //img.Save(ms, ImageFormat.Bmp);
                //ms.Seek(0, SeekOrigin.Begin);
                //BitmapImage bi = new BitmapImage();
                //bi.BeginInit();
                //bi.StreamSource = ms;
                //bi.EndInit();

                //bi.Freeze();
                //Dispatcher.BeginInvoke(new ThreadStart(delegate
                //{
                //    frameHolder.Source = bi;
                //}));
            }
            catch (Exception ex)
            {
            }
        }

        private void btCapturar_Click(object sender, RoutedEventArgs e)
        {
            SalvarImagem();
        }
        private void SalvarImagem()
        {

            string localImagens = myConfig.Imagem;

            if (nomeCliente != null && nomeCliente != "")
            {
                try
                {


                    DirectoryInfo dir = new DirectoryInfo(localImagens);
                    FileInfo[] files = dir.GetFiles(nomeCliente + ".*");
                    if (files.Length >= 1)
                    {
                        MessageBoxResult result = MessageBox.Show("Já existe uma IMAGEM do cliente " + nomeCliente +
                                 " salva. Deseja substituir?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            try
                            {

                                if (frameHolder.Source != null)
                                {
                                    var encoder = new PngBitmapEncoder();
                                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)frameHolder.Source));

                                    //File.Delete(localImagens + @"\" + nomeCliente);
                                    Foto.ExcluirImagem(nomeCliente);

                                    using (FileStream stream = new FileStream(localImagens + @"\" + nomeCliente + ".jpg", FileMode.Create)) encoder.Save(stream);
                                    cv.btImagem.ImageSource = Foto.GetImagemByNome(nomeCliente);
                                    MessageBox.Show("Imagem do Cliente Salva.");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Erro Windows 10 ao Capturar Imagem.");
                                }
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("ERRO ao SALVAR Imagem do CLIENTE: " + nomeCliente + "\n na pasta: " + localImagens + "\n\n\n" + exc);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não foram feitas alterações na imagem do cliente: " + nomeCliente);
                        }
                    }
                    else if (files.Length == 0)
                    {
                        if (frameHolder.Source != null)
                        {
                            //cv.btImagem.ImageSource = null;
                            //cv.btImagem.Freeze();
                            var encoder = new PngBitmapEncoder();
                            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)frameHolder.Source));
                            using (FileStream stream = new FileStream(localImagens + @"\" + nomeCliente + ".jpg", FileMode.Create)) encoder.Save(stream);
                            cv.btImagem.ImageSource = Foto.GetImagemByNome(nomeCliente);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro Windows 10 ao Capturar Imagem.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Salvar Imagem: \n\n\n" + ex);
                }
            }


        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {                
            //LocalWebCam.Stop();
            //LocalWebCam.WaitForStop();
            LocalWebCam.SignalToStop();
        }
    }   //fim class
}
