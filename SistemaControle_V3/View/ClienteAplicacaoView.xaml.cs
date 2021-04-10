using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SistemaControle_V3
{
    public partial class ClienteAplicacaoView : UserControl
    {

        MainWindow mw;
        //RepresaContext dc = new RepresaContext();
        Cliente cliente;
        int idEmprestimo = 0;
        int diaUtil = 0;

        List<Parcela> parcelas = new List<Parcela>();
        List<Feriado> feriados = new List<Feriado>();

        Parcela parcela = new Parcela();


        public ClienteAplicacaoView(MainWindow mainWindow, Cliente cliente2)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.cliente = cliente2;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 53;
            this.Width = mw.Width - 10;

            using (RepresaContext dc = new RepresaContext())
            {
                if (cliente.IdCliente > 0)
                {
                    btImagem.ImageSource = Foto.GetImagemByNome(cliente.NomeCliente).Item2;
                    nomeClienteTxt.Content = cliente.NomeCliente;
                    cpfTxt.Content = "Cpf: " + cliente.Cpf;
                    telefoneTxt.Content = "Telefone: " + cliente.TelCelularzap;

                    List<int> idsEmp = (from emp in dc.Emprestimos where (emp.IdCliente == cliente.IdCliente && emp.StatusEmprestimo == false) select emp.IdEmprestimo).ToList();
                    decimal divida = 0;
                    foreach (int i in idsEmp)
                    {
                        divida += (from par in dc.Parcelas where (par.IdEmprestimo == i && par.Paga == false) select par.ValorParcela).Sum();
                    }
                    totalDividaTxt.Content = "Dívida: " + string.Format("{0:C}", divida);
                }
                cbAtendente.ItemsSource = dc.Atendentes.Select(at => at.NomeAtendente).ToList();
                FPagamento.ItemsSource = dc.FormaPagamentos.Select(fp => fp.NomeFormaPagamento).ToList();
                feriados = dc.Feriados.ToList();
            }

        }


        private void getIdEmprestimo()
        {
            try
            {
                if (DataCadastro.DateTime == null) MessageBox.Show("Erro, por favor Verifique a Data de Cadastro da Aplição", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                DateTime dataAtual = DataCadastro.DateTime ?? DateTime.Now;
                int ultimoDia = MyConfig.UltimoDia(dataAtual);

                DateTime inicio = new DateTime(dataAtual.Year, dataAtual.Month, 1);
                DateTime fim = new DateTime(dataAtual.Year, dataAtual.Month, ultimoDia);

                using (RepresaContext dc = new RepresaContext())
                {
                    IQueryable<string> codigos = (from rf in dc.Emprestimos where (rf.DataCadastro >= inicio && rf.DataCadastro <= fim) orderby rf.IdEmprestimo descending select rf.CodEmprestimo).Take(5);
                    CodigosAntigo.Content = "Últimos Códigos\n\n";
                    if (codigos.Count() < 1) { CodigosAntigo.Content = "Primeira Aplicação do mês " + dataAtual.Month; }
                    else
                    {
                        foreach (var item in codigos)
                        {
                            CodigosAntigo.Content += item + "\n";
                        }
                    }


                    string codAntigo = dc.Emprestimos.Where(emp => emp.DataCadastro >= inicio && emp.DataCadastro <= fim).OrderByDescending(emp => emp.IdEmprestimo).Select(emp => emp.CodEmprestimo).FirstOrDefault();


                    int dias = 0;

                    if (string.IsNullOrEmpty(codAntigo)) dias = 0;
                    else dias = int.Parse(codAntigo.Substring(0, 2));

                    dias += 1;

                    if (dias < 10) { codAntigo = "0" + dias; } else { codAntigo = "" + dias; }
                    if (inicio.Month < 10) { codAntigo += "/0" + inicio.Month; } else { codAntigo += "/" + inicio.Month; }
                    codAntigo += "/" + inicio.Year;
                    string codigoBanco = dc.Emprestimos.Where(emp => emp.CodEmprestimo == codAntigo).Select(emp => emp.CodEmprestimo).FirstOrDefault();

                    if (codAntigo.Equals(codigoBanco)) CodEmprestimo.Foreground = Brushes.Red;
                    else CodEmprestimo.Foreground = Brushes.DarkBlue;

                    CodEmprestimo.Value = codAntigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        //----------------------------------------------------  BUTOES ---------------------------------------------------
        private void btCadCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cliente.IdCliente > 0)
                {
                    ClienteCadastroView cliView = new ClienteCadastroView(mw, cliente.IdCliente);
                    mw.Navegador(cliView);
                }
                else if (cliente.IdCliente == 0 || cliente.IdCliente < 0)
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

        private void btFichaCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cliente.IdCliente > 0)
                {
                    ClienteFichaView empView = new ClienteFichaView(mw, cliente.IdCliente);
                    mw.Navegador(empView);
                }
                else if (cliente.IdCliente == 0 || cliente.IdCliente < 0)
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

        private void btGerarParcela_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                DateTime datainicio = PrimeiraParcela.DateTime ?? DateTime.Now;

                parcelas.Clear();
                parcelaDataGrid.ItemsSource = null;
                long qtd = QtdParcela.Value ?? 0;

                for (int i = 0; i < qtd; i++)
                {
                    parcela = new Parcela();
                    DateTime dataParcela = datainicio.AddMonths(i);


                    if (diaUtil > 0)
                    {
                        dataParcela = new DateTime(dataParcela.Year, dataParcela.Month, 1);
                        int contDiaUtil = 0, cont = 0;

                        while (contDiaUtil < diaUtil)
                        {
                            dataParcela = dataParcela.AddDays(cont);
                            dataParcela = getDiaUltil(dataParcela);
                            contDiaUtil++;
                            cont = 1;
                        }

                    }
                    else dataParcela = getDiaUltil(dataParcela);

                    parcela.Vencimento = dataParcela;
                    parcela.ValorParcela = ValorParcela.Value ?? 0;
                    parcela.FormaPagamento = FPagamento.Text;
                    parcelas.Add(parcela);
                }

                parcelaDataGrid.ItemsSource = parcelas;
                btInsert.IsEnabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PARCELAS!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btInsert_Clikc(object sender, RoutedEventArgs e)
        {

            try
            {
                using (RepresaContext dc = new RepresaContext())
                {
                    if (!ValidarCampos()) return;

                    ProgressDialog pd = new ProgressDialog();
                    pd.Show();

                    Emprestimo testCod = new Emprestimo();
                    var testCods = dc.Emprestimos.Where(ep => (ep.CodEmprestimo.Contains(CodEmprestimo.Value.ToString()))).ToList();
                    if (testCods.Count > 0)
                    {
                        MessageBox.Show("Atenção: O Campo Código: " + CodEmprestimo.Value.ToString() + " já existe no banco de dados!\n\n Por favor insira o proximo Código.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                        pd.Close();
                    }

                    Emprestimo emprestimo = new Emprestimo();

                    emprestimo.IdCliente = cliente.IdCliente;
                    emprestimo.CodEmprestimo = CodEmprestimo.Value.ToString();
                    emprestimo.DataCadastro = DataCadastro.DateTime;
                    emprestimo.Valor = Aplicacao.Value ?? 0;
                    emprestimo.Taxa = (decimal?)(Taxa.PercentValue ?? 0);
                    emprestimo.ValorTotal = ValorTotal.Value ?? 0;
                    emprestimo.QtdParcela = (int)(QtdParcela.Value ?? 0);
                    emprestimo.ValorParcela = ValorParcela.Value ?? 0;
                    emprestimo.ValorComissao = ValorComissao.Value ?? 0;
                    emprestimo.NomeAtendente = cbAtendente.Text;
                    emprestimo.PrimeiraParcela = PrimeiraParcela.DateTime;

                    if (!string.IsNullOrEmpty(Observacao.Text)) emprestimo.Observacao = Observacao.Text;
                    if (!string.IsNullOrEmpty(FPagamento.Text)) emprestimo.FormaPagamento = FPagamento.Text;

                    emprestimo.DataCadastroAlteracao = DateTime.Now;

                    emprestimo.Refinanciado = false;
                    emprestimo.Complemento = 0;
                    emprestimo.StatusEmprestimo = false;


                    dc.Emprestimos.Add(emprestimo);
                    dc.SaveChanges();



                    idEmprestimo = emprestimo.IdEmprestimo;

                    if (idEmprestimo > 0)
                    {
                        if (parcelas.Count > 0)
                        {
                            foreach (var parcela1 in parcelas)
                            {
                                parcela1.IdEmprestimo = idEmprestimo;
                                //mw.dc.Parcelas.Add(parcela1);
                            }
                            dc.Parcelas.AddRange(parcelas);
                            dc.SaveChanges();
                            emprestimo.IdEmprestimo = 0;

                            foreach (var parcela1 in parcelas)
                            {
                                parcela1.IdParcela = 0;
                            }

                            var parameterIdEmprestimo = new SqlParameter
                            {
                                ParameterName = "@idEmprestimo",
                                SqlDbType = System.Data.SqlDbType.Int,
                                Value = idEmprestimo,
                            };
                            dc.Database.ExecuteSqlRaw("SP_EmprestimoP_Parcela @idEmprestimo", parameterIdEmprestimo);

                            pd.Close();

                            MessageBox.Show("Aplicação cadastrada com Sucesso.", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            Emprestimo empDelete = dc.Emprestimos.Where(em => (em.IdEmprestimo == idEmprestimo)).FirstOrDefault();
                            dc.Emprestimos.Remove(empDelete);
                            dc.SaveChanges();

                            pd.Close();

                            MessageBox.Show("Erro! ao gerar as Parcelas (PARCELAS MENOR QUE 0)!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }

                    LimparControles();
                }
                ClienteFichaView empView = new ClienteFichaView(mw, cliente.IdCliente);
                mw.Navegador(empView);

            }
            catch (Exception ex)
            {
                using (RepresaContext dc = new RepresaContext())
                {
                    Emprestimo empDelete = dc.Emprestimos.Where(em => (em.IdEmprestimo == idEmprestimo)).FirstOrDefault();
                    if (empDelete.IdEmprestimo > 0)
                    {
                        dc.Emprestimos.Remove(empDelete);
                        dc.SaveChanges();

                    }
                }
                Clipboard.SetText(ex + "");
                MessageBox.Show("Erro ao salvar a APLICAÇÃO!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

        }

        private void LimparControles()
        {
            DataCadastro.DateTime = DateTime.Now;
            CodEmprestimo.Value = null;
            Aplicacao.Value = null;
            Taxa.PercentValue = null;
            QtdParcela.Value = null;
            ValorParcela.Value = null;
            ValorTotal.Value = null;
            PrimeiraParcela.DateTime = null;
            ValorComissao.Value = null;
            cbAtendente.Text = null;
            Observacao.Text = null;
            FPagamento.Text = null;
            parcelaDataGrid.ItemsSource = null;
            btInsert.IsEnabled = false;

        }
        private bool ValidarCampos()
        {
            if (DataCadastro.DateTime == null) { MessageBox.Show("O Campo DATA CADASTRO não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (CodEmprestimo.Value.ToString() == null) { MessageBox.Show("O Campo CODEMPRESTIMO não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (Aplicacao.Value < 0) { MessageBox.Show("O Campo APLICAÇÃO deve ser maior ou igual a Zero", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (Taxa.PercentValue < 0) { MessageBox.Show("O Campo TAXA deve ser maior ou igual a Zero", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (QtdParcela.Value < 1) { MessageBox.Show("O Campo QTD PARCELA não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (ValorParcela.Value < 0) { MessageBox.Show("O Campo VALOR PARCELA deve ser maior ou igual a Zero", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (ValorTotal.Value < 0) { MessageBox.Show("O Campo VALOR TOTAL deve ser maior ou igual a Zero", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (PrimeiraParcela.DateTime == null) { MessageBox.Show("O Campo PRIMEIRA PARCELA não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (ValorComissao.Value < 0) { MessageBox.Show("O Campo VALOR COMISSÃO deve ser maior ou igual a Zero", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (cbAtendente.Text == "") { MessageBox.Show("O Campo ATENDENTE não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            if (FPagamento.Text == "") { MessageBox.Show("O Campo FORMA PAGAMENTO não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return false; }
            return true;
        }



        //----------------------------------------------------  EVENTOS ---------------------------------------------------
        private void CodEmprestimo_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                string codAntigo2 = null;
                if (CodEmprestimo.Value == null) return;

                using (RepresaContext dc = new RepresaContext())
                {
                    codAntigo2 = dc.Emprestimos.Where(n => n.CodEmprestimo.Contains(CodEmprestimo.Value.ToString())).Select(n => n.CodEmprestimo).FirstOrDefault();
                }

                if (codAntigo2 == null)
                {
                    CodEmprestimo.Foreground = Brushes.DarkBlue;
                }
                else if (codAntigo2.Length > 1)
                {
                    CodEmprestimo.Foreground = Brushes.Red;
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR: \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

        }

        private void Taxa_PercentValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CalculoPorcentagem();
        }
        private void Aplicacao_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculoPorcentagem();

        }
        private void CalculoPorcentagem()
        {
            if (Aplicacao.Value > 0 && Taxa.PercentValue > 0)
            {
                double aplicacao = (double)(Aplicacao.Value ?? 0);
                double taxa = Taxa.PercentValue ?? 0;
                ValorTotal.Value = (decimal?)(((taxa / 100) * aplicacao) + aplicacao);
                if (Taxa.PercentValue >= 40)
                {
                    ValorComissao.Value = (decimal?)((2.0 / 100.0) * aplicacao);
                }
                else if (Taxa.PercentValue < 40)
                {
                    ValorComissao.Value = (decimal?)((1.0 / 100.0) * aplicacao);
                }
            }
        }

        private void QtdParcela_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (QtdParcela.Value > 0 && ValorParcela.Value > 0)
            {
                long quantidade = QtdParcela.Value ?? 0;
                decimal valor = ValorParcela.Value ?? 0;
                ValorTotal.Value = quantidade * valor;
            }
        }

        private void DataCadastro_Loaded(object sender, RoutedEventArgs e)
        {
            DataCadastro.DateTime = DateTime.Now;
            DataCadastro.Focus();
            CodEmprestimo.Focus();
        }

        private void DataCadastro_LostFocus(object sender, RoutedEventArgs e)
        {
            getIdEmprestimo();
        }


        private void PrimeiraParcela_Loaded(object sender, RoutedEventArgs e)
        {
            PrimeiraParcela.DateTime = DateTime.Now.AddMonths(1);
            DataCadastro.Focus();
            CodEmprestimo.Focus();
        }

        private void lstUtil_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstUtil.SelectedIndex >= 0 && lstUtil.SelectedIndex < 11)
            {
                this.diaUtil = lstUtil.SelectedIndex;
            }
        }




        private DateTime getDiaUltil(DateTime data)
        {
            while (true)
            {
                if (data.DayOfWeek == DayOfWeek.Saturday)
                {
                    data = data.AddDays(2);
                    return getDiaUltil(data);
                }
                else if (data.DayOfWeek == DayOfWeek.Sunday)
                {
                    data = data.AddDays(1);
                    return getDiaUltil(data);
                }
                else if (isFeriado(data) == true)
                {
                    data = data.AddDays(1);
                    return getDiaUltil(data);
                }
                else return data;
            }
        }

        private bool isFeriado(DateTime data)
        {
            foreach (Feriado feriado in this.feriados)
            {
                if (data.Date == feriado.DataFeriado) return true;
            }
            return false;
        }

    }  //fim class
}
