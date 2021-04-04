
using Syncfusion.UI.Xaml.Grid.Helpers;
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
    /// Interação lógica para Recebimento.xam
    /// </summary>
    public partial class RecebimentoView : UserControl
    {
        MainWindow mw;
        MyConfig myConfig = MyConfig._getInstance();

        DateTime dataAtual;
        RepresaContext dc = new RepresaContext();
        public RecebimentoView(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
            dataAtual = DateTime.Now;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 53;
            this.Width = mw.Width - 10;
            view_RecebimentoDataGrid.MaxHeight = this.Height - 220;
            //view_RecebimentoDataGrid.MaxWidth = this.Width;
            buscaDados();
        }


        private void AnoTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                dataAtual = new DateTime((int)AnoTxt.Value, dataAtual.Month, dataAtual.Day);
                buscaDados();
            }
            catch (Exception error)
            {
                MessageBox.Show("Por favor verifique o valor digitado no campo ANO! \n\n" + error, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                AnoTxt.Value = 2000;
            }

        }
        private void lstAnos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int mes = 0;
            if (lstAnos.SelectedIndex >= 0 && lstAnos.SelectedIndex < 12)
            {
                mes = lstAnos.SelectedIndex + 1;
                DateTime dt = new DateTime(dataAtual.Year, mes, 10);
                dataAtual = new DateTime(dataAtual.Year, mes, MyConfig.UltimoDia(dt));
                buscaDados();
            }
        }
        private void btMais_Click(object sender, RoutedEventArgs e)
        {
            AnoTxt.Value += 1;
        }
        private void btMenos_Click(object sender, RoutedEventArgs e)
        {
            AnoTxt.Value -= 1;
        }






        private void buscaDados()
        {
            // 1 3 5 7 8 10 12
            int diaFevereiro = MyConfig.UltimoDia(dataAtual);
            

            DateTime inicio = new DateTime(dataAtual.Year, dataAtual.Month, 1);
            DateTime fim = new DateTime(dataAtual.Year, dataAtual.Month, diaFevereiro);
            view_RecebimentoDataGrid.ItemsSource = dc.ViewRecebimentos.Where(vr => (vr.Vencimento >= inicio && vr.Vencimento <= fim)).OrderBy(vr => vr.CodOrder).ToList();

            
            try { totalRecebimentoTextBox.Value = (from rf in dc.Parcelas where rf.Vencimento >= inicio && rf.Vencimento <= fim select rf.ValorParcela).Sum(); }
            catch { totalRecebimentoTextBox.Value = 0m; }

            switch (dataAtual.Month)
            {
                case 1:
                    Titulo.Content = "RECEBIMENTO REFERENTE A JANEIRO";
                    break;
                case 2:
                    Titulo.Content = "RECEBIMENTO REFERENTE A FEVEREIRO";
                    break;
                case 3:
                    Titulo.Content = "RECEBIMENTO REFERENTE A MARÇO";
                    break;
                case 4:
                    Titulo.Content = "RECEBIMENTO REFERENTE A ABRIL";
                    break;
                case 5:
                    Titulo.Content = "RECEBIMENTO REFERENTE A MAIO";
                    break;
                case 6:
                    Titulo.Content = "RECEBIMENTO REFERENTE A JUNHO";
                    break;
                case 7:
                    Titulo.Content = "RECEBIMENTO REFERENTE A JULHO";
                    break;
                case 8:
                    Titulo.Content = "RECEBIMENTO REFERENTE A AGOSTO";
                    break;
                case 9:
                    Titulo.Content = "RECEBIMENTO REFERENTE A SETEMBRO";
                    break;
                case 10:
                    Titulo.Content = "RECEBIMENTO REFERENTE A OUTUBRO";
                    break;
                case 11:
                    Titulo.Content = "RECEBIMENTO REFERENTE A NOVEMBRO";
                    break;
                case 12:
                    Titulo.Content = "RECEBIMENTO REFERENTE A DEZEMBRO";
                    break;
                default:
                    break;
            }

            
            AnoTxt.TextChanged -= AnoTxt_TextChanged;
            AnoTxt.Value = dataAtual.Year;
            AnoTxt.TextChanged += AnoTxt_TextChanged;
            AnoTxt.IsEnabled = true;
        }

        private void view_RecebimentoDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var visualcontainer = this.view_RecebimentoDataGrid.GetVisualContainer();
            // get the row and column index based on the pointer position 
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            if (rowColumnIndex.IsEmpty) return;

            var row = view_RecebimentoDataGrid.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ViewRecebimento viewRecebimento = (ViewRecebimento)row;
                ClienteFichaView empView = new ClienteFichaView(mw, viewRecebimento.IdCliente);
                mw.Navegador(empView);
            }
        }

        private void btPagarParcala_Click(object sender, RoutedEventArgs e)
        {
            object item = view_RecebimentoDataGrid.SelectedItem;
            Parcela par = new Parcela();
            try
            {
                ViewRecebimento vRecebimentoNow = (ViewRecebimento)view_RecebimentoDataGrid.SelectedItem;

                if (vRecebimentoNow.IdParcela > 0)
                {
                    par = dc.Parcelas.Where(em => (em.IdParcela == vRecebimentoNow.IdParcela)).FirstOrDefault();
                    par.Paga = vRecebimentoNow.Paga;
                    par.Observacao = vRecebimentoNow.Observacao;
                    dc.SaveChanges();
                    MessageBox.Show("Alterações Salvas", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscaDados();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

        }

        private void view_RecebimentoDataGrid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ViewRecebimento vRecebimentoNow = (ViewRecebimento)view_RecebimentoDataGrid.SelectedItem;

                if (vRecebimentoNow is null)
                {
                    MessageBox.Show("Por favor, primeiro selecione a linha e depois CLICK com o BOTÃO DIREITO do MOUSE", "INFORMAÇÕES!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                Cliente cli = dc.Clientes.Where(cli => (cli.IdCliente == vRecebimentoNow.IdCliente)).FirstOrDefault();
                if (cli.Marcado == true) cli.Marcado = false;
                else if (cli.Marcado == false) cli.Marcado = true;
                dc.SaveChanges();
                buscaDados();
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
    } //Fim Class
}
