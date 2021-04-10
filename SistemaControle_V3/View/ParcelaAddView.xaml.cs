using System;
using System.Windows;

namespace SistemaControle_V3
{
    /// <summary>
    /// Lógica interna para ParcelaAdd.xaml
    /// </summary>
    public partial class ParcelaAddView : Window
    {
        //RepresaContext dc = new RepresaContext();
        int idEmprestimo;
        int idCliente;
        MainWindow mw;

        public ParcelaAddView(MainWindow mw, int idCliente, int idEmprestimo)
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
                using (RepresaContext dc = new RepresaContext())
                {
                    dc.Parcelas.Add(par);
                    dc.SaveChanges();
                }

                MessageBox.Show("Nova Parcela Cadastrada com SUCESSO!", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);
                ClienteFichaView empView = new ClienteFichaView(mw, idCliente, idEmprestimo);
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
