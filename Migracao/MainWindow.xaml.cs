using Migracao.ModelAntigo;
using Migracao.ModelNovo;
using Newtonsoft.Json;
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

namespace Migracao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //AntigoContext antigoContext;         
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btIniciar(object sender, RoutedEventArgs e)
        {
            //List<AntigoCliente> antigos = antigoContext.AntigoClientes.ToList();

            //int endA = 0, conA = 0, cliA = 0; 

            

            //foreach(AntigoCliente antigo in antigos)
            //{
            //    try
            //    {
            //        using (NovoContext novoContext = new NovoContext())
            //        {
            //            Cliente cliente = novoContext.Clientes.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();
            //            Contato contato = novoContext.Contatos.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();
            //            Endereco endereco = novoContext.Enderecos.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();

                        
            //            cliente.DataCadastro = antigo.DataCadastro;
            //            cliente.DataAlteracao = DateTime.Now;
            //            //cliente.NomeCliente = antigo.NomeCliente;                      
            //            cliente.NomeClienteNormalizado = Stringnormalizada(antigo.NomeCliente.ToLower());
            //            cliente.Nascimento = antigo.DataNascimento;
            //            //cliente.Cpf = antigo.Cpf;
            //            cliente.Rg = antigo.Rg;
            //            cliente.Pesquisa = antigo.NomeClienteNormalizado + " " + antigo.Cpf + " " + antigo.TelResidencial + " " + antigo.TelCelularzap + " " + antigo.TelCelularzap;
            //            cliente.Empresa = antigo.Empresa;
            //            cliente.Cargo = antigo.Cargo;
            //            cliente.Salario = antigo.SalarioLiquido ?? 0;
            //            cliente.DataEmpresa = antigo.DataEmpresa ?? null;
            //            cliente.Indicacao = antigo.Indicacao;
            //            cliente.Observacao = antigo.Observacao;
            //            cliente.Marcado = antigo.Marcado;

            //            Referencia referencia = JsonConvert.DeserializeObject<Referencia>(antigo.Referencia);
            //            if (!referencia.Equals(null))
            //            {
            //                cliente.Referencia1 = referencia.Referencia01;
            //                cliente.Referencia2 = referencia.Referencia02;
            //                cliente.Referencia3 = referencia.Referencia03;
            //                cliente.TelefoneR1 = referencia.Telefone01;
            //                cliente.TelefoneR2 = referencia.Telefone02;
            //                cliente.TelefoneR3 = referencia.Telefone03;
            //            }

            //            EnderecoAntigo residencial = JsonConvert.DeserializeObject<EnderecoAntigo>(antigo.EndResidencial);
            //            if (!residencial.Equals(null))
            //            {
            //                endereco.Cep = residencial.Cep;
            //                endereco.Lagradouro = residencial.EnderecoBase;
            //                endereco.Bairro = residencial.Bairro;
            //                endereco.Cidade = residencial.Cidade;
            //                endereco.Estado = residencial.Estado;
            //                endereco.Complemento = residencial.PontoReferencia;
            //            }

            //            EnderecoAntigo empresarial = JsonConvert.DeserializeObject<EnderecoAntigo>(antigo.EndEmpresarial);
            //            if (!empresarial.Equals(null))
            //            {
            //                endereco.Ecep = empresarial.Cep;
            //                endereco.Elagradouro = empresarial.EnderecoBase;
            //                endereco.Ebairro = empresarial.Bairro;
            //                endereco.Ecidade = empresarial.Cidade;
            //                endereco.Eestado = empresarial.Estado;
            //                endereco.Ecomplemento = empresarial.PontoReferencia;
            //            }

                        
            //            contato.Telefone1 = antigo.TelResidencial;
            //            contato.Telefone2 = antigo.TelCelularzap;
            //            contato.Telefone3 = antigo.TelCelular2;
            //            contato.Etelefone1 = antigo.TelComercial1;
            //            contato.Etelefone2 = antigo.TelComercial2;
            //            contato.Etelefone3 = antigo.TelComercial3;
            //            contato.Email = antigo.Email;
            //            contato.Facebook = antigo.Facebook;
            //            contato.Instagram = antigo.Instagran;
                                                
            //            novoContext.SaveChanges();
            //            endA++;
            //            conA++;
            //            cliA++;
            //        }

            //        using (NovoContext novoContext = new NovoContext())
            //        {
            //            Cliente cliente = novoContext.Clientes.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();
            //            Contato contato = novoContext.Contatos.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();
            //            Endereco endereco = novoContext.Enderecos.Where(cli => cli.IdCliente == antigo.IdCliente).FirstOrDefault();


            //            cliente.DataCadastro = antigo.DataCadastro;
            //            cliente.DataAlteracao = DateTime.Now;
            //            //cliente.NomeCliente = antigo.NomeCliente;                      
            //            cliente.NomeClienteNormalizado = Stringnormalizada(antigo.NomeCliente.ToLower());
            //            cliente.Nascimento = antigo.DataNascimento;
            //            //cliente.Cpf = antigo.Cpf;
            //            cliente.Rg = antigo.Rg;
            //            cliente.Pesquisa = antigo.NomeClienteNormalizado + " " + antigo.Cpf + " " + antigo.TelResidencial + " " + antigo.TelCelularzap + " " + antigo.TelCelularzap;
            //            cliente.Empresa = antigo.Empresa;
            //            cliente.Cargo = antigo.Cargo;
            //            cliente.Salario = antigo.SalarioLiquido ?? 0;
            //            cliente.DataEmpresa = antigo.DataEmpresa ?? null;
            //            cliente.Indicacao = antigo.Indicacao;
            //            cliente.Observacao = antigo.Observacao;
            //            cliente.Marcado = antigo.Marcado;

            //            Referencia referencia = JsonConvert.DeserializeObject<Referencia>(antigo.Referencia);
            //            if (!referencia.Equals(null))
            //            {
            //                cliente.Referencia1 = referencia.Referencia01;
            //                cliente.Referencia2 = referencia.Referencia02;
            //                cliente.Referencia3 = referencia.Referencia03;
            //                cliente.TelefoneR1 = referencia.Telefone01;
            //                cliente.TelefoneR2 = referencia.Telefone02;
            //                cliente.TelefoneR3 = referencia.Telefone03;
            //            }

            //            endereco.IdCliente = cliente.IdCliente;

            //            EnderecoAntigo residencial = JsonConvert.DeserializeObject<EnderecoAntigo>(antigo.EndResidencial);
            //            if (!residencial.Equals(null))
            //            {
            //                endereco.Cep = residencial.Cep;
            //                endereco.Lagradouro = residencial.EnderecoBase;
            //                endereco.Bairro = residencial.Bairro;
            //                endereco.Cidade = residencial.Cidade;
            //                endereco.Estado = residencial.Estado;
            //                endereco.Complemento = residencial.PontoReferencia;
            //            }

            //            EnderecoAntigo empresarial = JsonConvert.DeserializeObject<EnderecoAntigo>(antigo.EndEmpresarial);
            //            if (!empresarial.Equals(null))
            //            {
            //                endereco.Ecep = empresarial.Cep;
            //                endereco.Elagradouro = empresarial.EnderecoBase;
            //                endereco.Ebairro = empresarial.Bairro;
            //                endereco.Ecidade = empresarial.Cidade;
            //                endereco.Eestado = empresarial.Estado;
            //                endereco.Ecomplemento = empresarial.PontoReferencia;
            //            }

            //            contato.IdCliente = cliente.IdCliente;
            //            contato.Telefone1 = antigo.TelResidencial;
            //            contato.Telefone2 = antigo.TelCelularzap;
            //            contato.Telefone3 = antigo.TelCelular2;
            //            contato.Etelefone1 = antigo.TelComercial1;
            //            contato.Etelefone2 = antigo.TelComercial2;
            //            contato.Etelefone3 = antigo.TelComercial3;
            //            contato.Email = antigo.Email;
            //            contato.Facebook = antigo.Facebook;
            //            contato.Instagram = antigo.Instagran;

            //            novoContext.SaveChanges();
            //        }

            //    }
            //    catch(Exception ex) {
            //        //MessageBox.Show("Erro! "+ antigo.IdCliente.ToString() + " \n\n" + ex);
            //        Clipboard.SetText(ex.ToString());
            //    }

            //}

            //MessageBox.Show("Endereco: " + endA + "Contato :" + conA + "Cliente :" + cliA);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //antigoContext = new AntigoContext();
            //NovoContext novoContext = new NovoContext();

            //antigoTxt.Text = antigoContext.AntigoClientes.Count() + " Clientes";
            //novoTxt.Text = novoContext.Clientes.Count() + " Clientes";
            //novoContext.Dispose();
        }


        public string Stringnormalizada(string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "\\.", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            /** Troca os espaços no início por "" **/
            str = str.Replace("^\\s+", "");
            /** Troca os espaços no início por "" **/
            str = str.Replace("\\s+$", "");
            /** Troca os espaços duplicados, tabulações e etc por " " **/
            str = str.Replace("\\s+", " ");
            return str;
        }
        
        // Scaffold-DbContext "Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=REPRESA04.MDF;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer   -Context "Context" -Tables Cliente -DataAnnotations -force



    } //**********************
}
