using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SistemaControle.Arquitetura;
using SistemaControle.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace SistemaControle.View
{
    /// <summary>
    /// Lógica interna para ParcelaAdd.xaml
    /// </summary>
    public partial class ParcelaAdd : Window
    {
        RepresaContext dc = new RepresaContext();
        int idEmprestimo;
        int idCliente;
        MainWindow mw;

        public ParcelaAdd(MainWindow mw, int idCliente, int idEmprestimo)
        {
            InitializeComponent();
            this.idEmprestimo = idEmprestimo;
            this.idCliente = idCliente;
            this.mw = mw;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
       
        private void btInserir_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    if (DataVencimento.DateTime == null) { MessageBox.Show("O Campo VENCIMENTO não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return; }
                    if (ValorParcela.Value < 1) { MessageBox.Show("O Campo VALOR PARCELA não está preenchido", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return; }


                    Parcela par = new Parcela();
                    par.IdEmprestimo = idEmprestimo;
                    par.ValorParcela = (decimal)ValorParcela.Value;
                    par.Vencimento = (DateTime)DataVencimento.DateTime;
                    par.Paga = false;
                    dc.Parcelas.Add(par);
                    dc.SaveChanges();
                    FireNet fire = new FireNet(mw);
                    par.IdParcela = 0;
                    Espelho espelho = new Espelho { Acao = "Inserir", Tipo = par.GetType(), Dado = JsonConvert.SerializeObject(par) };
                    Resultado resultado = fire.setFileJson(espelho);

                MessageBox.Show("Nova Parcela Cadastrada com SUCESSO!", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                    EmpView empView = new EmpView(mw, idCliente, idEmprestimo);
                    mw.Navegador(empView);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: Erro ao inserir a nova Parcela!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            

        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



    }
}
