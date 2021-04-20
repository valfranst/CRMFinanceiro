
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SistemaControle_V3
{
    /// <summary>
    /// Lógica interna para Camera.xaml
    /// </summary>
    public partial class Camera : Window
    {

        VideoCaptureDevice LocalWebCam;
        public FilterInfoCollection LoaclWebCamsCollection;

        ClienteCadastroView cv = null;
        private string nomeCliente = null;

        public Camera(ClienteCadastroView cv, string nomeCliente)
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
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString(), "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void btCapturar_Click(object sender, RoutedEventArgs e)
        {
            SalvarImagem();
        }
       
        private void SalvarImagem()
        {               
            try
            {        
                if (frameHolder.Source != null)
                {
                    var encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)frameHolder.Source));

                    Resultado result = Foto.SalvarImagemByNome(encoder, nomeCliente);
                    if (result.estado)
                    {
                        var retorno = Foto.GetImagemByNome(nomeCliente);
                        cv.btImagem.ImageSource = retorno.Item2;
                        MessageBox.Show("Imagem do Cliente Salva!", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else MessageBox.Show("Erro ao salvar Imagem!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error);
                    this.Close();
                }
                else MessageBox.Show("Erro Windows 10 ao Capturar Imagem.");
            }
            catch (Exception ex) { MessageBox.Show("Error ao Salvar Imagem: \n\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error); }             
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //LocalWebCam.Stop();
            //LocalWebCam.WaitForStop();
            //LocalWebCam.SignalToStop();
            CloseVideoSource();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            //LocalWebCam.Stop();
            //LocalWebCam.WaitForStop();
            //LocalWebCam.SignalToStop();
            CloseVideoSource();
        }

        private void CloseVideoSource()
        {

            LocalWebCam.NewFrame -= new NewFrameEventHandler(Cam_NewFrame);
            LocalWebCam.SignalToStop();
            LocalWebCam.WaitForStop();

            //if (!(LocalWebCam == null))
            //    if (LocalWebCam.IsRunning)
            //    {
            //        LocalWebCam.SignalToStop();
            //        LocalWebCam = null;
            //    }
        }


    }   //fim class
}
