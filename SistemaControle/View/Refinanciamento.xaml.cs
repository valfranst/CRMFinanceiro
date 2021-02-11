using SistemaControle.Arquitetura;
using SistemaControle.Model;
using Syncfusion.UI.Xaml.Grid;
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

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para Refinanciamento.xam
    /// </summary>
    public partial class Refinanciamento : UserControl
    {
        MainWindow mw;
        MyConfig myConfig = MyConfig._getInstance();

        DateTime dataAtual;
        RepresaContext dc = new RepresaContext();
        public Refinanciamento(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
            dataAtual = DateTime.Now;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 63;
            this.Width = mw.Width - 10;
            view_RefinanciarDataGrid.MaxHeight = this.Height - 200;
            //view_RefinanciarDataGrid.MaxWidth = this.Width;
            buscaDados();
        }

        private void buscaDados()
        {
            // 1 3 5 7 8 10 12
            int diaFevereiro = MyConfig.UltimoDia(dataAtual);

            DateTime inicio = new DateTime(dataAtual.Year, dataAtual.Month, 1);
            DateTime fim = new DateTime(dataAtual.Year, dataAtual.Month, diaFevereiro);
            if (btAlternarDados.IsChecked == true)
            {
                view_RefinanciarDataGrid.ItemsSource = dc.ViewRefinanciars.Where(vr => (vr.UltimaParcela >= inicio && vr.UltimaParcela <= fim && vr.ReferenciaEmprestimo == "0")).OrderBy(vr => vr.UltimaParcela).ToList();
                GridColumn columnExcluir = view_RefinanciarDataGrid.Columns[9];
                columnExcluir.Width = 80;

                GridColumn columnIncluir = view_RefinanciarDataGrid.Columns[8];
                columnIncluir.Width = 0;
            }
            else
            {
                view_RefinanciarDataGrid.ItemsSource = dc.ViewRefinanciars.Where(vr => (vr.UltimaParcela >= inicio && vr.UltimaParcela <= fim && vr.ReferenciaEmprestimo == null)).OrderBy(vr => vr.UltimaParcela).ToList();
                GridColumn columnExcluir = view_RefinanciarDataGrid.Columns[9];
                columnExcluir.Width = 0;

                GridColumn columnIncluir = view_RefinanciarDataGrid.Columns[8];
                columnIncluir.Width = 80;
            }

            //********************************************************************************************************************
            try { aRefinanciarTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.ReferenciaEmprestimo == null select rf.ValorParcela).Sum(); }
            catch { aRefinanciarTextBox.Value = 0m; }
            //********************************************************************************************************************
            try { complementoTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.ReferenciaEmprestimo == null select rf.Complemento).Sum(); }
            catch { complementoTextBox.Value = 0m; }            
            //********************************************************************************************************************
            try{ refinanciadoTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.Refinanciado == true && rf.ReferenciaEmprestimo == null select rf.ValorParcela).Sum(); }
            catch { refinanciadoTextBox.Value = 0; }
            //********************************************************************************************************************
                         

            switch (dataAtual.Month)
            {
                case 1:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A JANEIRO";
                    break;
                case 2:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A FEVEREIRO";
                    break;
                case 3:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A MARÇO";
                    break;
                case 4:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A ABRIL";
                    break;
                case 5:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A MAIO";
                    break;
                case 6:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A JUNHO";
                    break;
                case 7:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A JULHO";
                    break;
                case 8:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A AGOSTO";
                    break;
                case 9:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A SETEMBRO";
                    break;
                case 10:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A OUTUBRO";
                    break;
                case 11:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A NOVEMBRO";
                    break;
                case 12:
                    Titulo.Content = "REFINANCIAMENTO REFERENTE A DEZEMBRO";
                    break;
                default:
                    break;
            }
            AnoTxt.TextChanged -= AnoTxt_TextChanged;
            AnoTxt.Value = dataAtual.Year;
            AnoTxt.TextChanged += AnoTxt_TextChanged;
            AnoTxt.IsEnabled = true;

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
        private void btAlternarDados_Click(object sender, RoutedEventArgs e)
        {
            buscaDados();
        }


        private void view_RefinanciarDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var visualcontainer = this.view_RefinanciarDataGrid.GetVisualContainer();
            // get the row and column index based on the pointer position 
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            if (rowColumnIndex.IsEmpty) return;

            var row = view_RefinanciarDataGrid.SelectedItem;
            if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ViewRefinanciar viewRefinanciar = (ViewRefinanciar)row;
                EmpView empView = new EmpView(mw, viewRefinanciar.IdCliente);
                mw.Navegador(empView);
            }

        }


        private void btAtualizarRefinanciamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewRefinanciar vRefinanciarNow = (ViewRefinanciar)view_RefinanciarDataGrid.SelectedItem;

                if (vRefinanciarNow.IdEmprestimo > 0)
                {
                    Emprestimo emp = dc.Emprestimos.Where(emp => (emp.IdEmprestimo == vRefinanciarNow.IdEmprestimo)).FirstOrDefault();
                    if (vRefinanciarNow.Complemento > 0 && vRefinanciarNow.TotalRefinanciado == 0)
                    {
                        MessageBox.Show("Campo COMPLEMENTO preenchido. Por favor também prencha o campo REFINANCIADO.\n\n DADOS NÃO SALVOS!!!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        if (vRefinanciarNow.TotalRefinanciado > 0) { emp.Refinanciado = true; }
                        else { emp.Refinanciado = false; }

                        emp.Complemento = vRefinanciarNow.Complemento;
                        emp.TotalRefinanciado = vRefinanciarNow.TotalRefinanciado;
                        emp.Observacao = vRefinanciarNow.Observacao;


                        dc.SaveChanges();
                        MessageBox.Show("Alterações Salvas em! " + emp.CodEmprestimo, "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

        }
        private void ExcluirRefinanciamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewRefinanciar vRefinanciarNow = (ViewRefinanciar)view_RefinanciarDataGrid.SelectedItem;

                if (vRefinanciarNow.IdEmprestimo > 0)
                {
                    Emprestimo emp = dc.Emprestimos.Where(emp => (emp.IdEmprestimo == vRefinanciarNow.IdEmprestimo)).FirstOrDefault();
                    emp.ReferenciaEmprestimo = "0";

                    dc.SaveChanges();
                    MessageBox.Show("Refinanciamento Excluido! " + emp.CodEmprestimo, "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscaDados();
                    
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }


        }     
        private void IncluirRefinanciamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewRefinanciar vRefinanciarNow = (ViewRefinanciar)view_RefinanciarDataGrid.SelectedItem;

                if (vRefinanciarNow.IdEmprestimo > 0)
                {
                    Emprestimo emp = dc.Emprestimos.Where(emp => (emp.IdEmprestimo == vRefinanciarNow.IdEmprestimo)).FirstOrDefault();
                    emp.ReferenciaEmprestimo = null;

                    dc.SaveChanges();
                    MessageBox.Show("Refinanciamento Incluido! " + emp.CodEmprestimo, "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscaDados();

                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao Excluir Refinanciamento!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

        }

        private void view_RefinanciarDataGrid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ViewRefinanciar vRefinanciarNow = (ViewRefinanciar)view_RefinanciarDataGrid.SelectedItem;

                if (vRefinanciarNow is null)
                {
                    MessageBox.Show("Por favor, primeiro selecione a linha e depois CLICK com o BOTÃO DIREITO do MOUSE", "INFORMAÇÕES!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                
                Cliente cli = dc.Clientes.Where(cli => (cli.IdCliente == vRefinanciarNow.IdCliente)).FirstOrDefault();
                if(cli.Marcado == true) cli.Marcado = false;
                else if (cli.Marcado == false) cli.Marcado = true;
                dc.SaveChanges();
                buscaDados();   
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }


        }
    } //Fim Class
}