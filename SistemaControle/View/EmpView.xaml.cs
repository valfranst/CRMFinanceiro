using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SistemaControle.Arquitetura;
using SistemaControle.Model;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para EmpView.xam
    /// </summary>
    public partial class EmpView : UserControl
    {
        MainWindow mw;
        RepresaContext dc = new RepresaContext();
        int idCliente = 0;
        int idEmprestimo = 0;
        Cliente cliente;

        int linhasParcelas = 0;
        int linhaEmprestimo = 0;

        FireNet fire;

        public EmpView(MainWindow mainWindow, int idCliente2)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.idCliente = idCliente2;
        }
        public EmpView(MainWindow mainWindow, int idCliente2, int idEmprestimo2)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.idCliente = idCliente2;
            this.idEmprestimo = idEmprestimo2;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 55;
            this.Width = mw.Width - 2;
            SV_EmprestimoView.Height = mw.Height - 100;
            SV_EmprestimoView.Width = mw.Width - 28;
            DG_EmprestimoView.ItemsSource = dc.Emprestimos.Where(emp => emp.IdCliente == idCliente).ToObservableCollection();
            fire = new FireNet(mw);
            Cabecalho();
            buscarDados();
        }

       
        public void Cabecalho()
        {
            try
            {
                cliente = dc.Clientes.Single(c => c.IdCliente == idCliente);
                List<Emprestimo> emps = dc.Emprestimos.Where(emp => (emp.IdCliente == idCliente)).Take(3).ToList();                 

                if (cliente.IdCliente > 0)
                {
                    btImagem.ImageSource = Foto.GetImagemByNome(cliente.NomeCliente);

                    nomeClienteTxt.Content = cliente.NomeCliente;
                    cpfTxt.Content = "Cpf: " + cliente.Cpf;
                    telefoneTxt.Content = "Telefone: " + cliente.TelCelularzap;
                    List<int> idsEmp = (from emp in dc.Emprestimos where (emp.IdCliente == idCliente && emp.StatusEmprestimo == false) select emp.IdEmprestimo).ToList();
                    decimal divida = 0;
                    foreach (int i in idsEmp)
                    {
                        divida += (from par in dc.Parcelas where (par.IdEmprestimo == i && par.Paga == false) select par.ValorParcela).Sum();
                    }
                    totalDividaTxt.Content = "Dívida: " + string.Format("{0:C}", divida);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados pessoas do cliente!\n\n"+ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        public void buscarDados()
        {
            try
            {
                DG_EmprestimoView.ItemsSource = null;
                //DG_EmprestimoView.ItemsSource = mw.dc.Emprestimos.Where(emp => emp.IdCliente == idCliente).OrderBy(emp => emp.DataCadastro).ToList();
                DG_EmprestimoView.ItemsSource = dc.Emprestimos.Where(emp => emp.IdCliente == idCliente).ToList();
                DG_EmprestimoView.Items.Refresh();
                Cabecalho();

                if (linhaEmprestimo > 0 && linhaEmprestimo < 10000 && DG_EmprestimoView.Items.Count > 0)
                {
                    DG_EmprestimoView.SelectedIndex = linhaEmprestimo;
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados financeiros do cliente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btNovoEmprestimo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cliente.IdCliente > 0)
                {
                    if (mw.Equals(null) || cliente.Equals(null)) MessageBox.Show("ou");
                    EmpInsert empInsert = new EmpInsert(this.mw, cliente); 
                    this.mw.Navegador(empInsert);
                }
                else if (idCliente == 0 || idCliente < 0)
                {
                    MessageBox.Show("Dados do Cliente não estão carregados! \n\n Verifique se esse Cliente já está salvo no Sistema.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("Dados do Cliente não estão carregados! \n\n Verifique os campos: Nome do Cliente e Cod Cliente.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btVoltarClienteView_Click(object sender, RoutedEventArgs e)
        {
            ClienteView cv = new ClienteView(mw, idCliente);
            mw.Navegador(cv);
        }




        //----------------------------------------- EMPRESTIMO ----------------------------------------------------------

        private void DG_EmprestimoView_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
        {
            DataGridRow linha = e.Row as DataGridRow;
            Emprestimo emprestimo = (Emprestimo)linha.DataContext;
            SfDataGrid detais = e.DetailsElement as SfDataGrid;
            detais.ItemsSource = dc.ViewParcelaEmprestimos.Where(par => par.IdEmprestimo == emprestimo.IdEmprestimo).ToList();
            linhasParcelas = detais.GetRecordsCount();
        }

        private void dataGrid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta / 10);
                eventArg.RoutedEvent = MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((Control)sender).Parent as UIElement;
                parent?.RaiseEvent(eventArg);
            }
        }

        private void DG_EmprestimoView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (DG_EmprestimoView.Items.Count > 0)
                {
                    Emprestimo emp = ((DataGrid)sender).SelectedItem as Emprestimo;
                    if (emp != null)
                    {
                        idEmprestimo = emp.IdEmprestimo;
                    }
                    linhaEmprestimo = DG_EmprestimoView.SelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void AtualizarEmprestimo_Click(object sender, RoutedEventArgs e)
        {

            object item = DG_EmprestimoView.SelectedItem;
            string id = ""; // banco = "", formaPagamento = "", observacao = "", taxaS = "";
            int idEmprestimo2 = 0;
            Emprestimo emp = new Emprestimo();
            try
            {
                id = (DG_EmprestimoView.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text;
                idEmprestimo2 = Convert.ToInt32(id);
                if (idEmprestimo2 > 0)
                {
                    Emprestimo empGrid = (Emprestimo)DG_EmprestimoView.SelectedItem;
                    emp = dc.Emprestimos.Where(em => (em.IdEmprestimo == idEmprestimo2)).FirstOrDefault();

                    if (empGrid.Complemento > 0 && empGrid.TotalRefinanciado.Equals(null))
                    {
                        MessageBox.Show("Atenção, campo COMPLEMENTO preenchido. Por favor também prencha o campo REFINANCIADO.\n\n DADOS NÃO SALVOS!!!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {

                        emp.Banco = empGrid.Banco;
                        emp.Valor = empGrid.Valor;
                        emp.ValorTotal = empGrid.ValorTotal;
                        emp.Taxa = empGrid.Taxa;
                        emp.FormaPagamento = empGrid.FormaPagamento;
                        emp.Observacao = empGrid.Observacao;
                        emp.Refinanciado = empGrid.Refinanciado;
                        emp.TotalRefinanciado = empGrid.TotalRefinanciado;
                        emp.Complemento = empGrid.Complemento;
                        emp.DataCadastroAlteracao = DateTime.Now;
                        if (empGrid.TotalRefinanciado > 0) { emp.Refinanciado = true; }
                        else { emp.Refinanciado = false; }

                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = emp.GetType(), Dado = JsonConvert.SerializeObject(emp) };
                        Resultado resultado = fire.setFileJson(espelho);

                        MessageBox.Show("Alterações Salvas.", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscarDados();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }


            //****************************

        }
        private void ExcluirEmprestimo_Click(object sender, RoutedEventArgs e)
        {

            object item = DG_EmprestimoView.SelectedItem;
            string id = "";
            int idEmprestimo2 = 0;
            Emprestimo emp = new Emprestimo();
            try
            {
                id = (DG_EmprestimoView.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text;
                idEmprestimo2 = Convert.ToInt32(id);
                if (idEmprestimo2 > 0)
                {
                    emp = dc.Emprestimos.Where(em => (em.IdEmprestimo == idEmprestimo2)).FirstOrDefault();
                    string codigo1 = emp.CodEmprestimo;
                    dc.Emprestimos.Remove(emp);
                    dc.SaveChanges();

                    Espelho espelho = new Espelho { Acao = "Excluir", Tipo = emp.GetType(), Dado = JsonConvert.SerializeObject(emp) };
                    Resultado resultado = fire.setFileJson(espelho);

                    MessageBox.Show("Aplicação " + codigo1 + " Excluido!", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscarDados();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao Excluir o Emprestimo!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }


            //****************************

        }




        //----------------------------------------- PARCELA ----------------------------------------------------------
        private void parcelaDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {               
            ParcelaAdd PAD = new ParcelaAdd(this.mw, idCliente, idEmprestimo);
            PAD.ShowDialog();             
        }

        private void parcelaDG_QueryCoveredRange(object sender, Syncfusion.UI.Xaml.Grid.GridQueryCoveredRangeEventArgs e)
        {
            if (e.RowColumnIndex.ColumnIndex == 0)
            {
                if (e.RowColumnIndex.RowIndex >= 0 && e.RowColumnIndex.RowIndex <= linhasParcelas)
                {
                    e.Range = new CoveredCellInfo(0, 0, 1, linhasParcelas);
                    SfDataGrid grid = (SfDataGrid)sender;
                    grid.GetVisualContainer().InvalidateMeasureInfo();
                    e.Handled = true;
                }
            }
        }

        private void btAtualizarParcela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewParcelaEmprestimo obj = ((FrameworkElement)sender).DataContext as ViewParcelaEmprestimo; 

                if (obj.IdParcela > 0)
                {
                    Parcela par = dc.Parcelas.Where(pa => (pa.IdParcela == obj.IdParcela)).FirstOrDefault();
                    par.Paga = obj.Paga;
                    par.ValorParcela = obj.ValorParcela;
                    par.Vencimento = obj.Vencimento;
                    par.FormaPagamento = obj.FormaPagamento;
                    par.Observacao = obj.Observacao;

                    //MessageBox.Show(obj.ObservacaoEmprestimo);

                    Emprestimo emprestimo = dc.Emprestimos.Where(emp => emp.IdEmprestimo == obj.IdEmprestimo).FirstOrDefault();
                    emprestimo.Observacao = obj.ObservacaoEmprestimo;

                    dc.SaveChanges();
                                      
                    Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = par.GetType(), Dado = JsonConvert.SerializeObject(par) };
                    Resultado resultado = fire.setFileJson(espelho);
                    espelho = new Espelho { Acao = "Atualizar", Tipo = emprestimo.GetType(), Dado = JsonConvert.SerializeObject(emprestimo) };
                    resultado = fire.setFileJson(espelho);

                    MessageBox.Show("Alterações salvas com SUCESSO!", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscarDados();
                }
                else MessageBox.Show("sem parcela selecionada.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Salvar: \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        private void btExcluirParcela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewParcelaEmprestimo obj = ((FrameworkElement)sender).DataContext as ViewParcelaEmprestimo;

                if (obj != null)
                {
                    Parcela par = dc.Parcelas.Where(pa => (pa.IdParcela == obj.IdParcela)).FirstOrDefault();
                    int idEmprestimoAtulizar = par.IdEmprestimo;
                    dc.Parcelas.Remove(par);
                    dc.SaveChanges();
                                        
                    Espelho espelho = new Espelho { Acao = "Excluir", Tipo = par.GetType(), Dado = JsonConvert.SerializeObject(par) };
                    Resultado resultado = fire.setFileJson(espelho);

                    MessageBox.Show("Parcela Excluida com SUCESSO! ", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Excluir: \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        private void btAnteciparRefi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewParcelaEmprestimo obj = ((FrameworkElement)sender).DataContext as ViewParcelaEmprestimo;

                if (obj != null)
                {
                    Emprestimo emp = dc.Emprestimos.Where(emp => (emp.IdEmprestimo == obj.IdEmprestimo)).FirstOrDefault();
                    emp.ReferenciaEmprestimo = "0";
                    dc.SaveChanges();

                    Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = emp.GetType(), Dado = JsonConvert.SerializeObject(emp) };
                    Resultado resultado = fire.setFileJson(espelho);

                    MessageBox.Show("Refinanciamento Excluido! " + emp.CodEmprestimo, "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Excluir Refinanciamento!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }           
       

        private void parcelaDG_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            SfDataGrid dataGrid = (SfDataGrid)sender;
            var rowIndex = e.RowColumnIndex.RowIndex;
            var columnIndex = e.RowColumnIndex.ColumnIndex;

            var range = dataGrid.CoveredCells.GetCoveredCellInfo(rowIndex, columnIndex);
            dataGrid.RemoveRange(range);
            dataGrid.GetVisualContainer().InvalidateMeasure();

            //dataGrid.GridColumnSizer.ResetAutoCalculationforAllColumns();
            //dataGrid.GridColumnSizer.Refresh();

        }
    } //Fim Class
}

