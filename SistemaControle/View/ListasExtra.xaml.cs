using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using SistemaControle.Arquitetura;
using SistemaControle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SistemaControle.View
{
    /// <summary>
    /// Interação lógica para ListasExtra.xam
    /// </summary>
    public partial class ListasExtra : UserControl
    {

        MainWindow mw;
        MyConfig myConfig = MyConfig._getInstance();

        DateTime dataAtual;
        RepresaContext dc = new RepresaContext();
        FireNet fire;


        public ListasExtra(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
            dataAtual = DateTime.Now;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 43;
            this.Width = mw.Width - 10;
            fire = new FireNet(mw);
            buscaDados();
        }

        public void buscaDados()
        {
            using (RepresaContext dc = new RepresaContext())
            {
                DG_Feriado.ItemsSource = dc.Feriados.ToList();
                DG_FPagamento.ItemsSource = dc.FormaPagamentos.ToList();
                DG_Atendente.ItemsSource = dc.Atendentes.ToList();
            }
        }



        private void btFeriados_Clikc(object sender, RoutedEventArgs e)
        {
            ProgressDialog pd = new ProgressDialog();
            pd.Show();

            using (RepresaContext dc = new RepresaContext())
            {
                List<Feriado> feriados = dc.Feriados.ToList();
                foreach (Feriado feriado in feriados)
                {

                    try
                    {
                        Feriado inserindo = new Feriado();
                        inserindo.NomeFeriado = feriado.NomeFeriado;
                        inserindo.DataFeriado = feriado.DataFeriado.AddYears(1);
                        inserindo.Anual = feriado.Anual;
                        inserindo.Descricao = feriado.Descricao;
                        if (dc.Feriados.Where(fr => fr.DataFeriado == inserindo.DataFeriado).Count() >= 1) { }
                        else
                        {
                            using (RepresaContext dc2 = new RepresaContext())
                            {
                                dc2.Feriados.Add(inserindo);
                                dc2.SaveChanges();
                            }
                            Feriado feriadoNuvem = inserindo;
                            feriadoNuvem.IdFeriado = 0;
                            Espelho espelho = new Espelho { Acao = "Inserir", Tipo = inserindo.GetType(), Dado = JsonConvert.SerializeObject(feriadoNuvem) };
                            Resultado resultado = fire.setFileJson(espelho);
                        }

                        int dias = (DateTime.Now - feriado.DataFeriado).Days;
                        if (dias > 730) 
                        {
                            Feriado excluindo = dc.Feriados.Where(fr => fr.IdFeriado == feriado.IdFeriado).FirstOrDefault();
                            dc.Feriados.Remove(excluindo);
                            dc.SaveChanges();
                            Espelho espelho = new Espelho { Acao = "Excluir", Tipo = excluindo.GetType(), Dado = JsonConvert.SerializeObject(excluindo) };
                            Resultado resultado = fire.setFileJson(espelho);
                        }
                        buscaDados();

                    }
                    catch (SqlException ex) { MessageBox.Show("Error!\n\n" + ex); }
                }
            }

            buscaDados();
            pd.Close();

        }            
        private void btExcluirFeriado_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Feriado feriado = (Feriado)DG_Feriado.SelectedItem;

                if (feriado.IdFeriado > 0)
                {
                    Feriado excluindo = dc.Feriados.Where(fe => fe.IdFeriado == feriado.IdFeriado).FirstOrDefault();
                    using (RepresaContext dc = new RepresaContext())
                    {
                        dc.Feriados.Remove(excluindo);
                        dc.SaveChanges();
                    }

                    Espelho espelho = new Espelho { Acao = "Excluir", Tipo = excluindo.GetType(), Dado = JsonConvert.SerializeObject(excluindo) };
                    Resultado resultado = fire.setFileJson(espelho);
                    buscaDados();
                    MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    buscaDados();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao EXCLUIR feriado!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void btSalvarFeriado_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Feriado feriado = (Feriado)DG_Feriado.SelectedItem;

                using (RepresaContext dc = new RepresaContext())
                {
                    if (feriado.IdFeriado > 0)
                    {
                        Feriado atualizando = dc.Feriados.Where(fe => fe.IdFeriado == feriado.IdFeriado).FirstOrDefault();
                        atualizando.NomeFeriado = feriado.NomeFeriado;
                        atualizando.DataFeriado = feriado.DataFeriado;
                        atualizando.Anual = feriado.Anual;
                        atualizando.Descricao = feriado.Descricao;
                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = atualizando.GetType(), Dado = JsonConvert.SerializeObject(atualizando) };
                        Resultado resultado = fire.setFileJson(espelho);
                        MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                }
            }
            catch (NullReferenceException) { }
            catch (Exception ex) { MessageBox.Show("Error ao SALVAR alterações no feriado!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
            
        }         
        private void DG_Feriado_AddNewRowInitiating(object sender, Syncfusion.UI.Xaml.Grid.AddNewRowInitiatingEventArgs e)
        {               
            Feriado feriado = e.NewObject as Feriado;
            feriado.IdFeriado = 0;
            feriado.NomeFeriado = "Novo "+ DateTime.Now.ToString("yyyyMMddHHmmss"); 
            feriado.DataFeriado = DateTime.Now;
            feriado.Anual = false;
            feriado.Descricao = "";
        }




        //****************************************************************************************
        private void btExcluirAtendente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Atendente atendente = (Atendente)DG_Atendente.SelectedItem;

                using (RepresaContext dc = new RepresaContext())
                {
                    if (atendente.IdAtendente > 0)
                    {
                        dc.Atendentes.Remove(atendente);
                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = atendente.GetType(), Dado = JsonConvert.SerializeObject(atendente) };
                        Resultado resultado = fire.setFileJson(espelho);
                        MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao EXCLUIR Atendente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void btSalvarAtendente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Atendente atendente = (Atendente)DG_Atendente.SelectedItem;

                using (RepresaContext dc = new RepresaContext())
                {
                    if (atendente.IdAtendente > 0)
                    {
                        Atendente atualizando = dc.Atendentes.Where(fe => fe.IdAtendente == atendente.IdAtendente).FirstOrDefault();
                        atualizando.NomeAtendente = atendente.NomeAtendente;
                        atualizando.Descricao = atendente.Descricao;
                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = atualizando.GetType(), Dado = JsonConvert.SerializeObject(atualizando) };
                        Resultado resultado = fire.setFileJson(espelho);
                        MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao SALVAR alterações em Atendente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void DG_Atendente_AddNewRowInitiating(object sender, Syncfusion.UI.Xaml.Grid.AddNewRowInitiatingEventArgs e)
        {               
            Atendente atendente = e.NewObject as Atendente;
            atendente.IdAtendente = 0;
            atendente.NomeAtendente = "Novo";
            atendente.Descricao = "";
        }



        //****************************************************************************************
        private void btExcluirFPagamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FormaPagamento fpagamento = (FormaPagamento)DG_FPagamento.SelectedItem;

                if (fpagamento.IdFormaPagamento > 0)
                {
                    using (RepresaContext dc = new RepresaContext())
                    {
                        //FormaPagamento excluindo = dc.FormaPagamentos.Where(fe => fe.IdFormaPagamento == fpagamento.IdFormaPagamento).FirstOrDefault();                     
                        dc.FormaPagamentos.Remove(fpagamento);
                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Excluir", Tipo = fpagamento.GetType(), Dado = JsonConvert.SerializeObject(fpagamento) };
                        Resultado resultado = fire.setFileJson(espelho);
                        MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                    buscaDados();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao EXCLUIR feriado!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void btSalvarFPagamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FormaPagamento fpagamento = (FormaPagamento)DG_FPagamento.SelectedItem;
                using (RepresaContext dc = new RepresaContext())
                {
                    if (fpagamento.IdFormaPagamento > 0)
                    {
                        FormaPagamento atualizando = dc.FormaPagamentos.Where(fe => fe.IdFormaPagamento == fpagamento.IdFormaPagamento).FirstOrDefault();
                        atualizando.NomeFormaPagamento = fpagamento.NomeFormaPagamento;
                        atualizando.Descricao = fpagamento.Descricao;
                        dc.SaveChanges();
                        Espelho espelho = new Espelho { Acao = "Atualizar", Tipo = atualizando.GetType(), Dado = JsonConvert.SerializeObject(atualizando) };
                        Resultado resultado = fire.setFileJson(espelho);
                        MessageBox.Show("Alterações realizadas!", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                        buscaDados();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error ao SALVAR alterações em Atendente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        private void DG_FPagamento_AddNewRowInitiating(object sender, Syncfusion.UI.Xaml.Grid.AddNewRowInitiatingEventArgs e)
        {              
            FormaPagamento fpagamento = new FormaPagamento();
            fpagamento = e.NewObject as FormaPagamento;
            fpagamento.IdFormaPagamento = 0;
            fpagamento.NomeFormaPagamento = "Novo";
            fpagamento.Descricao = "";
        }




    } //fim
}
