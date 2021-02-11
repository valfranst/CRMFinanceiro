using Newtonsoft.Json;
using SistemaControle.Arquitetura;
using SistemaControle.Model;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para Producao.xam
    /// </summary>
    public partial class Producao : UserControl
    {
        MainWindow mw;
        MyConfig myConfig = MyConfig._getInstance();

        DateTime dataAtual;
        RepresaContext dc = new RepresaContext();
        string meta = "";

        public Producao(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
            dataAtual = DateTime.Now;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 73;
            this.Width = mw.Width - 10;
            
            meta = myConfig.Meta;
            view_ClienteEmprestimoDataGrid.MaxHeight = mw.Height - 300;
            //view_ClienteEmprestimoDataGrid.MaxWidth = mw.Width - 50;
                          
            buscaDados();
        }

        public void relatorios()
        {
            
            // 1 3 5 7 8 10 12
            int diaFevereiro = MyConfig.UltimoDia(dataAtual);

            DateTime inicio = new DateTime(dataAtual.Year, dataAtual.Month, 1);
            DateTime fim = new DateTime(dataAtual.Year, dataAtual.Month, diaFevereiro);


            decimal valor = 0, meta = 0;
            int aplicacoesTotal = 0, aplicacoesNaoRefinanciadas = 0;

            //******  VALOR
            try
            {
                valor = (from rf in dc.Emprestimos where rf.DataCadastro >= inicio && rf.DataCadastro <= fim select rf.Valor).Sum();
            }
            catch { valor = 0; }
            //***** META 
            try
            {
                if (decimal.TryParse(myConfig.Meta, out meta)) MetaTxt.Value = meta;
            }
            catch { MetaTxt.Value = 0m; }
            //***** APLICAÇÕES TOTAIS
            try
            {
                aplicacoesTotal = (from rf in dc.Emprestimos where rf.DataCadastro >= inicio && rf.DataCadastro <= fim select rf.IdEmprestimo).Count();
            }
            catch { aplicacoesTotal = 0; }
            //***** APLICAÇÕES TOTAIS
            try
            {
                aplicacoesNaoRefinanciadas = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.Refinanciado == false select rf.IdEmprestimo).Count();
            }
            catch { aplicacoesNaoRefinanciadas = 0; }



            //*********************************** COMISSÃO *********************************************************************************
            try
            {
                var sells = dc.Emprestimos
                    .Where(a => a.DataCadastro >= inicio && a.DataCadastro <= fim)
                .GroupBy(a => a.NomeAtendente)
                .Select(a => new { Atendente = a.Key, Comissao = a.Sum(b => b.ValorComissao) })
                .OrderByDescending(a => a.Atendente)
                .ToList();
                ComissoesTXT.Content = "";
                foreach (var item in sells)
                {
                    string item2 = item.Atendente + "  " + toMoeda(item.Comissao);
                    ComissoesTXT.Content += item2 + "\n";
                }
            }
            catch (InvalidOperationException ex)
            {
                ComissoesTXT.Content = "COMISSÕES\n\n" + toMoeda(0m);
            }


            //************************************ SOMA TAXA ********************************************************************************  
            try
            { somaTaxaTextBox.Value = (from rf in dc.Emprestimos where rf.DataCadastro >= inicio && rf.DataCadastro <= fim select rf.ValorComissao).Sum(); }
            catch { somaTaxaTextBox.Value = 0m; }


            //************************************ SOMA PRODUÇÃO *****************************************************************************
            try
            {somaProducaoTextBox.Value = (from rf in dc.Emprestimos where rf.DataCadastro >= inicio && rf.DataCadastro <= fim select rf.Valor).Sum(); }
            catch { somaProducaoTextBox.Value = 0m; }
                                       


            //************************************ META TEXT / FALTA PARA META ****************************************************************
            try
            {
                if (valor > 0 && meta > 0)
                {
                    metaPercentTextBox.PercentValue = (double?)((valor / meta) * 100); //((valor / meta) * 100);

                    Decimal resultado = (valor - meta);
                    if (resultado > 0)
                    {
                        faltaTextBox.Foreground = Brushes.Blue;
                        faltaTextBox.Text = "Meta concluida +: " + toMoeda(resultado);
                    }
                    else if (resultado < 0)
                    {
                        faltaTextBox.Foreground = Brushes.Red;
                        faltaTextBox.Text = "Falta: " + toMoeda(resultado);
                    }


                }
            }
            catch
            {
                metaPercentTextBox.PercentValue = (double?)0m;
                faltaTextBox.Text = "Inconclusivo: " + toMoeda(0m);
            }



            //************************************ NA RUA *************************************************************************************
            try { naRuaTextBox.Value = valor; }
            catch { naRuaTextBox.Value = 0m; }


            //************************************ A REFINANCIAR ********************************************************************************
            try { aRefiTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.ReferenciaEmprestimo == null select rf.ValorParcela).Sum(); }
            catch { aRefiTextBox.Value = 0m; }


            //************************************ REFINANCIADO ********************************************************************************
            try { refinanciadoTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.Refinanciado == true && rf.ReferenciaEmprestimo == null select rf.ValorParcela).Sum(); }
            catch { refinanciadoTextBox.Value = 0m; }


            //************************************ COMPLEMENTO ********************************************************************************
            try { complementoTextBox.Value = (from rf in dc.Emprestimos where rf.UltimaParcela >= inicio && rf.UltimaParcela <= fim && rf.ReferenciaEmprestimo == null select rf.Complemento).Sum(); }
            catch { complementoTextBox.Value = 0m; }


            //************************************ CLIENTES REFI ********************************************************************************
            if (refinanciadoTextBox.Value > 0 && aRefiTextBox.Value > 0)
            {
                //Decimal percenteRefi = (refinanciamento / refinanciado);
                Decimal percenteRefi = ((decimal)(refinanciadoTextBox.Value / aRefiTextBox.Value));
                clientesRefiTextBox.Text = "Refinanciado " + percenteRefi.ToString("P1", CultureInfo.InvariantCulture) + " com " + aplicacoesTotal + " Aplicações";
            }
            else
            {
                clientesRefiTextBox.Text = "Refinanciado " + "0.0%" + " com " + 0 + " Aplicações";
            }





            //*************************** line 03 *******************

            try{ entradaAplicacaoTextBox.Value = (from rf in dc.Parcelas where rf.Vencimento >= inicio && rf.Vencimento <= fim select rf.ValorParcela).Sum(); }
            catch { entradaAplicacaoTextBox.Value = 0m; }

            try { saidaAplicacaoTextBox.Value = (from emp in dc.Emprestimos where emp.DataCadastro >= inicio && emp.DataCadastro <= fim select emp.Valor).Sum(); }
            catch { saidaAplicacaoTextBox.Value = 0m; }


            DateTime hoje = DateTime.Now;
            if (hoje > inicio)
            {
                try { AVencerTextBox.Value = (from rf in dc.Parcelas where rf.Vencimento >= DateTime.Now && rf.Vencimento <= fim && rf.Paga == false select rf.ValorParcela).Sum(); }
                catch { AVencerTextBox.Value = 0m; }
            }
            else AVencerTextBox.Value = 0m;

            if (hoje < fim)
            {
                try { atrazadoTextBox.Value = (from rf in dc.Parcelas where rf.Vencimento >= inicio && rf.Vencimento <= DateTime.Now && rf.Paga == false select rf.ValorParcela).Sum(); }
                catch { atrazadoTextBox.Value = 0m; }
            }
            else
            {
                try { atrazadoTextBox.Value = (from rf in dc.Parcelas where rf.Vencimento >= inicio && rf.Vencimento <= fim && rf.Paga == false select rf.ValorParcela).Sum(); }
                catch { atrazadoTextBox.Value = 0m; }
            }

            //**********************************************************************
            try { despesaTextBox.Value = (from desp in dc.DespesaMensals where desp.DataCadastro >= inicio && desp.DataCadastro <= fim select desp.Valor).Sum(); }
            catch { despesaTextBox.Value = 0m; }
            //**********************************************************************
            try { reEsperadoTextBox.Value = entradaAplicacaoTextBox.Value - saidaAplicacaoTextBox.Value - despesaTextBox.Value; }
            catch { reEsperadoTextBox.Value = 0m; }

            try { reAtualTextBox.Value = entradaAplicacaoTextBox.Value - saidaAplicacaoTextBox.Value - despesaTextBox.Value - AVencerTextBox.Value - atrazadoTextBox.Value; }
            catch { reAtualTextBox.Value = 0m; }


        }


        private void buscaDados()
        {

            // 1 3 5 7 8 10 12
            int diaFevereiro = MyConfig.UltimoDia(dataAtual);

            DateTime inicio = new DateTime(dataAtual.Year, dataAtual.Month, 1);
            DateTime fim = new DateTime(dataAtual.Year, dataAtual.Month, diaFevereiro);

            view_ClienteEmprestimoDataGrid.ItemsSource = dc.ViewAplicacaoClientes.Where(ce => (ce.DataCadastro >= inicio && ce.DataCadastro <= fim)).OrderBy(ce => ce.CodOrder).ToList();


            switch (dataAtual.Month)
            {
                case 1:
                    Titulo.Content = "PRODUÇÃO REFERENTE A JANEIRO";
                    break;
                case 2:
                    Titulo.Content = "PRODUÇÃO REFERENTE A FEVEREIRO";
                    break;
                case 3:
                    Titulo.Content = "PRODUÇÃO REFERENTE A MARÇO";
                    break;
                case 4:
                    Titulo.Content = "PRODUÇÃO REFERENTE A ABRIL";
                    break;
                case 5:
                    Titulo.Content = "PRODUÇÃO REFERENTE A MAIO";
                    break;
                case 6:
                    Titulo.Content = "PRODUÇÃO REFERENTE A JUNHO";
                    break;
                case 7:
                    Titulo.Content = "PRODUÇÃO REFERENTE A JULHO";
                    break;
                case 8:
                    Titulo.Content = "PRODUÇÃO REFERENTE A AGOSTO";
                    break;
                case 9:
                    Titulo.Content = "PRODUÇÃO REFERENTE A SETEMBRO";
                    break;
                case 10:
                    Titulo.Content = "PRODUÇÃO REFERENTE A OUTUBRO";
                    break;
                case 11:
                    Titulo.Content = "PRODUÇÃO REFERENTE A NOVEMBRO";
                    break;
                case 12:
                    Titulo.Content = "PRODUÇÃO REFERENTE A DEZEMBRO";
                    break;
                default:
                    break;
            }
            relatorios();
            AnoTxt.IsEnabled = false;
            AnoTxt.Value = dataAtual.Year;
            AnoTxt.IsEnabled = true;

        }


        private void view_ClienteEmprestimoDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {                
            try
            {

                var visualcontainer = this.view_ClienteEmprestimoDataGrid.GetVisualContainer();
                // get the row and column index based on the pointer position 
                var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
                if (rowColumnIndex.IsEmpty) return;

                var row = view_ClienteEmprestimoDataGrid.SelectedItem;
                if (row is null) MessageBox.Show("Usuário não identificado, não é possível prosseguir!", "IMPOSSIBILITADO!", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                {
                    ViewAplicacaoCliente vac = (ViewAplicacaoCliente)row;
                    int idCliente = (from rf in dc.Emprestimos where rf.IdEmprestimo == vac.IdEmprestimo select rf.IdCliente).First();
                    EmpView empView = new EmpView(mw, idCliente);
                    mw.Navegador(empView);
                }                  


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Não foi possivél iniciar os detalhes desse empréstimo!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Não foi possivél iniciar os detalhes desse empréstimo!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Não foi possivél iniciar os detalhes desse empréstimo!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
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


       

        private void btCalcularRelatorio_Click(object sender, RoutedEventArgs e)
        {
            myConfig.Meta = MetaTxt.Value.ToString();
            relatorios();
        }

        private void despesaTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            using (RepresaContext con = new RepresaContext())
            {
                FireNet fire = new FireNet(mw);
                string id = dataAtual.Month + "" + dataAtual.Year;
                DespesaMensal dm = dc.DespesaMensals.Where(desp => desp.IdDespesaMensal == id).FirstOrDefault();
                if(dm is null)
                {
                    dm = new DespesaMensal();
                    dm.IdDespesaMensal = id;
                    dm.DataCadastro = dataAtual;
                    dm.Valor = despesaTextBox.Value ?? 0m;
                    dc.DespesaMensals.Add(dm);
                    dc.SaveChanges();
                                        
                    Espelho espelho = new Espelho { Acao = "Inserir", Tipo = dm.GetType(), Dado = JsonConvert.SerializeObject(dm) };
                    Resultado resultado = fire.setFileJson(espelho);

                    relatorios();
                }
                else
                {
                    dm.DataCadastro = dataAtual;
                    dm.Valor = despesaTextBox.Value ?? 0m;
                    dc.SaveChanges();

                    Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = dm.GetType(), Dado = JsonConvert.SerializeObject(dm) };
                    Resultado resultado = fire.setFileJson(espelho);

                    relatorios();
                }
            }
        }


        //*********************************************************

        public string toMoeda(decimal? decimalValue)
        {
            if (decimalValue == null) decimalValue = 0;
            return $"{decimalValue:C}";
        }

        private void view_ClienteEmprestimoDataGrid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                ViewAplicacaoCliente vProducaoNow = (ViewAplicacaoCliente)view_ClienteEmprestimoDataGrid.SelectedItem;

                if (vProducaoNow is null)
                {
                    MessageBox.Show("Por favor, primeiro selecione a linha e depois CLICK com o BOTÃO DIREITO do MOUSE", "INFORMAÇÕES!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                Cliente cli = dc.Clientes.Where(cli => (cli.IdCliente == vProducaoNow.IdCliente)).FirstOrDefault();
                if(cli.Marcado == true) cli.Marcado = false;
                else if(cli.Marcado == false) cli.Marcado = true;
                dc.SaveChanges();
                buscaDados();
            }
            catch (Exception ex) { MessageBox.Show("Error ao salvar alterações!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
    } //Fim Class
}
