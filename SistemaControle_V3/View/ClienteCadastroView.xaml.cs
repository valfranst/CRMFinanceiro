using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SistemaControle_V3
{
    public partial class ClienteCadastroView : UserControl
    {
        MainWindow mw;
        int idCliente = 0;
        MyConfig myConfig = MyConfig._getInstance();
        Cliente cliente;
        Resultado resultado;

        public ClienteCadastroView(MainWindow mainWindow, int idCliente)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.idCliente = idCliente;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.Height = mw.Height - 53;
            this.Width = mw.Width - 10;
            buscaDados();
        }

        public void buscaDados()
        {
            try
            {
                if (idCliente > 0)
                {
                    using (RepresaContext dc = new RepresaContext())
                    {
                        this.cliente = dc.Clientes.Where(cli => cli.IdCliente == idCliente).FirstOrDefault();
                    }

                    nomeClienteTextBox.Text = cliente.NomeCliente;

                    nascimentoDT.DateTime = cliente.DataNascimento;
                    if (cliente.DataNascimento is not null)
                    {
                        DateTime dataConvertida = (DateTime)cliente.DataNascimento;
                        int dias = (DateTime.Now - dataConvertida).Days;
                        int anos = dias / 360;
                        int meses = (dias % 360) / 30;
                        idadeTextBox.Text = anos + " anos e " + meses + " meses";
                    }
                    cpfTextBox.Text = cliente.Cpf;
                    rgTextBox.Text = cliente.Rg;

                    telResidencialTextBox.Text = cliente.TelResidencial;
                    telCelularzapTextBox.Text = cliente.TelCelularzap;
                    telCelular2TextBox.Text = cliente.TelCelular2;
                    emailTextBox.Text = cliente.Email;
                    facebookTextBox.Text = cliente.Facebook;
                    instagranTextBox.Text = cliente.Instagran;

                    cepTextBox.Value = cliente.Rcep;
                    ruaTextBox.Text = cliente.Rlagradouro;
                    bairroTextBox.Text = cliente.Rbairro;
                    cidadeTextBox.Text = cliente.Rcidade;
                    estadoTextBox.Text = cliente.Restado;
                    pontoReferenciaTextBox.Text = cliente.Rcomplemento;

                    empresaTextBox.Text = cliente.Empresa;
                    cargoTextBox.Text = cliente.Cargo;
                    salarioLiquidoTextBox.Value = cliente.SalarioLiquido;

                    DataEmpresaDT.DateTime = cliente.DataEmpresa;
                    if (DataEmpresaDT.DateTime != null)
                    {
                        DateTime dataConvertida2 = (DateTime)cliente.DataEmpresa;
                        int dias2 = (DateTime.Now - dataConvertida2).Days;
                        int anos2 = dias2 / 360;
                        int meses2 = (dias2 % 360) / 30;
                        tempoServicoTextBox.Text = anos2 + " anos e " + meses2 + " meses";
                    }
                    telComercial1TextBox.Text = cliente.TelComercial1;
                    telComercial2TextBox.Text = cliente.TelComercial2;
                    telComercial3TextBox.Text = cliente.TelComercial3;

                    cepEmpTextBox.Value = cliente.Ecep;
                    ruaEmpTextBox.Text = cliente.Elagradouro;
                    bairroEmpTextBox.Text = cliente.Ebairro;
                    cidadeEmpTextBox.Text = cliente.Ecidade;
                    estadoEmpTextBox.Text = cliente.Eestado;
                    pontoReferenciaEmpTextBox.Text = cliente.Ecomplemento;

                    referencia01TextBox.Text = cliente.Nreferencia1;
                    referencia02TextBox.Text = cliente.Nreferencia2;
                    referencia03TextBox.Text = cliente.Nreferencia3;
                    telReferencia01TextBox.Text = cliente.TelefoneR1;
                    telReferencia02TextBox.Text = cliente.TelefoneR2;
                    telReferencia03TextBox.Text = cliente.TelefoneR3;

                    indicacaoTextBox.Text = cliente.Indicacao;
                    observacaoTextBox.Text = cliente.Observacao;

                    var retorno = Foto.GetImagemByNome(cliente.NomeCliente);
                    resultado = retorno.Item1;
                    if (resultado.estado) btImagem.ImageSource = retorno.Item2;
                    else MessageBox.Show(resultado.mensagem);

                    btInsert.IsEnabled = false;
                    btInsert.Visibility = Visibility.Collapsed;

                    btSalvar.IsEnabled = true;
                    btExcluir.IsEnabled = true;
                    btSalvar.Visibility = Visibility.Visible;
                    btExcluir.Visibility = Visibility.Visible;
                }
                else
                {
                    btInsert.IsEnabled = true;
                    btInsert.Visibility = Visibility.Visible;

                    btSalvar.IsEnabled = false;
                    btExcluir.IsEnabled = false;
                    btSalvar.Visibility = Visibility.Collapsed;
                    btExcluir.Visibility = Visibility.Collapsed;
                };
            }
            catch (Exception ex) { MessageBox.Show("Dados do Cliente não estão carregados! \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }


        private void btNovaAplicacao_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!cliente.Equals(null))
                {
                    ClienteAplicacaoView empInsert = new ClienteAplicacaoView(this.mw, cliente);
                    this.mw.Navegador(empInsert);
                }
                else
                {
                    MessageBox.Show("Dados do Cliente não estão carregados! \n\n Verifique se esse Cliente já está salvo no Sistema.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btAplicacoes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!cliente.Equals(null))
                {
                    ClienteFichaView empView = new ClienteFichaView(this.mw, cliente.IdCliente);
                    this.mw.Navegador(empView);
                }
                else
                {
                    MessageBox.Show("Dados do Cliente não estão carregados! \n\n Verifique se esse Cliente já está salvo no Sistema.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        #region COMANDOS CRUD

        private void btInsert_Click(object sender, RoutedEventArgs e)
        {
            if (nomeClienteTextBox.Text.Length < 5)
            {
                MessageBox.Show("ERRO: O campo Nome Cliente deve está preenchido com no minímo 5 dígitos!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                nomeClienteTextBox.Focus();
            }
            else if (cpfTextBox.Text.Length < 11) { cpfTextBox.Focus(); return; }
            else if (rgTextBox.Text.Length < 6) { rgTextBox.Focus(); return; }
            else if (nascimentoDT.DateTime is null) { nascimentoDT.Focus(); return; }
            else if (idCliente == 0)
            {
                try
                {
                    Cliente inserindo = new Cliente();
                    using (RepresaContext dc = new RepresaContext())
                    {
                        inserindo.NomeCliente = nomeClienteTextBox.Text;
                        inserindo.NomeClienteNormalizado = Stringnormalizada(nomeClienteTextBox.Text.ToLower());

                        inserindo.DataNascimento = nascimentoDT.DateTime;
                        inserindo.Cpf = cpfTextBox.Text;
                        inserindo.Rg = rgTextBox.Text;
                        inserindo.TelResidencial = telResidencialTextBox.Text;
                        inserindo.TelCelularzap = telCelularzapTextBox.Text;
                        inserindo.TelCelular2 = telCelular2TextBox.Text;
                        inserindo.Email = emailTextBox.Text;
                        inserindo.Facebook = facebookTextBox.Text;
                        inserindo.Instagran = instagranTextBox.Text;

                        inserindo.Rcep = cepTextBox.Text;
                        inserindo.Rlagradouro = ruaTextBox.Text;
                        inserindo.Rbairro = bairroTextBox.Text;
                        inserindo.Rcidade = cidadeTextBox.Text;
                        inserindo.Restado = estadoTextBox.Text;
                        inserindo.Rcomplemento = pontoReferenciaTextBox.Text;

                        inserindo.Empresa = empresaTextBox.Text;
                        inserindo.Cargo = cargoTextBox.Text;
                        inserindo.SalarioLiquido = salarioLiquidoTextBox.Value;
                        inserindo.DataEmpresa = DataEmpresaDT.DateTime;
                        inserindo.TelComercial1 = telComercial1TextBox.Text;
                        inserindo.TelComercial2 = telComercial2TextBox.Text;
                        inserindo.TelComercial3 = telComercial3TextBox.Text;

                        inserindo.Ecep = cepEmpTextBox.Text;
                        inserindo.Elagradouro = ruaEmpTextBox.Text;
                        inserindo.Ebairro = bairroEmpTextBox.Text;
                        inserindo.Ecidade = cidadeEmpTextBox.Text;
                        inserindo.Eestado = estadoEmpTextBox.Text;
                        inserindo.Ecomplemento = pontoReferenciaEmpTextBox.Text;

                        inserindo.Nreferencia1 = referencia01TextBox.Text;
                        inserindo.Nreferencia2 = referencia02TextBox.Text;
                        inserindo.Nreferencia3 = referencia03TextBox.Text;
                        inserindo.TelefoneR1 = telReferencia01TextBox.Text;
                        inserindo.TelefoneR2 = telReferencia02TextBox.Text;
                        inserindo.TelefoneR3 = telReferencia03TextBox.Text;

                        inserindo.Indicacao = indicacaoTextBox.Text;
                        inserindo.Observacao = observacaoTextBox.Text;

                        dc.Clientes.Add(inserindo);
                        dc.SaveChanges();

                        idCliente = inserindo.IdCliente;
                    }
                    inserindo.IdCliente = 0;

                    buscaDados();
                    mw.clienteList.AtualizarDados();
                    MessageBox.Show("Novo Cliente Cadastrado com Sucesso!\n\n", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                catch (Exception ex) { MessageBox.Show("Erro ao CADASTRAR o novo Cliente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

            }
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (nomeClienteTextBox.Text.Length < 5)
            {
                MessageBox.Show("ERRO: O campo Nome Cliente deve está preenchido com no minímo 5 dígitos!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                nomeClienteTextBox.Focus();
            }
            else if (cpfTextBox.Text.Length < 11) { cpfTextBox.Focus(); return; }
            else if (rgTextBox.Text.Length < 6) { rgTextBox.Focus(); return; }
            else if (nascimentoDT.DateTime is null) { nascimentoDT.Focus(); return; }
            else if (cliente is not null)
            {
                try
                {
                    Cliente editando = new Cliente();
                    string nomeAntigo = cliente.NomeCliente;

                    using (RepresaContext dc = new RepresaContext())
                    {
                        editando = dc.Clientes.Where(cli => cli.IdCliente == cliente.IdCliente).FirstOrDefault();

                        editando.NomeCliente = nomeClienteTextBox.Text;
                        editando.NomeClienteNormalizado = Stringnormalizada(nomeClienteTextBox.Text.ToLower());

                        editando.DataNascimento = nascimentoDT.DateTime;
                        editando.Cpf = cpfTextBox.Text;
                        editando.Rg = rgTextBox.Text;
                        editando.TelResidencial = telResidencialTextBox.Text;
                        editando.TelCelularzap = telCelularzapTextBox.Text;
                        editando.TelCelular2 = telCelular2TextBox.Text;
                        editando.Email = emailTextBox.Text;
                        editando.Facebook = facebookTextBox.Text;
                        editando.Instagran = instagranTextBox.Text;

                        editando.Rcep = cepTextBox.Text;
                        editando.Rlagradouro = ruaTextBox.Text;
                        editando.Rbairro = bairroTextBox.Text;
                        editando.Rcidade = cidadeTextBox.Text;
                        editando.Restado = estadoTextBox.Text;
                        editando.Rcomplemento = pontoReferenciaTextBox.Text;

                        editando.Empresa = empresaTextBox.Text;
                        editando.Cargo = cargoTextBox.Text;
                        editando.SalarioLiquido = salarioLiquidoTextBox.Value;
                        editando.DataEmpresa = DataEmpresaDT.DateTime;
                        editando.TelComercial1 = telComercial1TextBox.Text;
                        editando.TelComercial2 = telComercial2TextBox.Text;
                        editando.TelComercial3 = telComercial3TextBox.Text;

                        editando.Ecep = cepEmpTextBox.Text;
                        editando.Elagradouro = ruaEmpTextBox.Text;
                        editando.Ebairro = bairroEmpTextBox.Text;
                        editando.Ecidade = cidadeEmpTextBox.Text;
                        editando.Eestado = estadoEmpTextBox.Text;
                        editando.Ecomplemento = pontoReferenciaEmpTextBox.Text;

                        editando.Nreferencia1 = referencia01TextBox.Text;
                        editando.Nreferencia2 = referencia02TextBox.Text;
                        editando.Nreferencia3 = referencia03TextBox.Text;
                        editando.TelefoneR1 = telReferencia01TextBox.Text;
                        editando.TelefoneR2 = telReferencia02TextBox.Text;
                        editando.TelefoneR3 = telReferencia03TextBox.Text;

                        editando.Indicacao = indicacaoTextBox.Text;
                        editando.Observacao = observacaoTextBox.Text;

                        dc.SaveChanges();
                    }

                    string nomeNovo = editando.NomeCliente;

                    Foto.RenomearImagem(nomeNovo, nomeAntigo);

                    buscaDados();

                    mw.clienteList.AtualizarDados();

                    MessageBox.Show("Cliente MODIFICADO com Sucesso!\n\n", "CONCLUIDO!", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                catch (Exception ex) { MessageBox.Show("Erro ao MODIFICAR o Cliente!\n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }

            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {

            if (cliente is not null)
            {
                MessageBoxResult result = MessageBox.Show("Tem certeza que dejesa excluir o cliente " + cliente.NomeCliente +
                                    " e todos os seus dados?", "Excluir Cliente?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {

                        using (RepresaContext dc = new RepresaContext())
                        {
                            Cliente excluindo = dc.Clientes.Where(cli => cli.IdCliente == cliente.IdCliente).FirstOrDefault();
                            dc.Clientes.Remove(excluindo);
                            dc.SaveChanges();
                        }

                        Foto.ExcluirImagem(cliente.NomeCliente);
                        MessageBox.Show("Cliente: " + cliente.NomeCliente + ", EXCLUIDO com sucesso!", "Concluido!", MessageBoxButton.OK, MessageBoxImage.Information);
                        mw.Navegador(mw.clienteList);
                        mw.txtPesquisa = null;
                    }
                    catch (Exception ex) { MessageBox.Show("Erro ao Excluir! \n\n" + ex, "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning); }
                }
                else
                {
                    MessageBox.Show("Não foram feitas alterações no cliente", "INFORMAÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        #endregion


        //************************************************************************************
        private void btWebCan_Click(object sender, RoutedEventArgs e)
        {
            if (nomeClienteTextBox.Text.Length < 5)
            {
                MessageBox.Show("ERRO: O campo Nome Cliente deve está preenchido com no minímo 5 dígitos!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                nomeClienteTextBox.Focus();
            }
            else
            {
                Camera wc = new Camera(this, nomeClienteTextBox.Text);
                wc.ShowDialog();

            }
        }

        private void btArquivo_Click(object sender, RoutedEventArgs e)
        {
            if (nomeClienteTextBox.Text.Length < 5)
            {
                MessageBox.Show("ERRO: O campo Nome Cliente deve está preenchido com no minímo 5 dígitos!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                nomeClienteTextBox.Focus();
            }
            else
            {
                var retorno = Foto.CopiarArquivo(cliente.NomeCliente);
                resultado = retorno.Item1;
                if (resultado.estado) btImagem.ImageSource = retorno.Item2;
                else MessageBox.Show(resultado.mensagem);
            }
        }


        //*************************************************************************************
        private void btPesquisarCep1_Click(object sender, RoutedEventArgs e)
        {

            if (IsConnected() == 0)
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cepTextBox.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; // Sai da rotina
                }
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                                        cepTextBox.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    ruaTextBox.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    //complementoTextBox.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    bairroTextBox.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    cidadeTextBox.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    estadoTextBox.Text = valor[1];
                                }

                                cont++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possível acessar a INTERNET. Por favor preencha os dados MANUALMENTE. \n\n Ou aguarde o reestabelecimento a conexão com a INTERNET.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void btPesquisarCep2_Click(object sender, RoutedEventArgs e)
        {

            if (IsConnected() == 0)
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cepEmpTextBox.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível!", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return; // Sai da rotina
                }
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado!", "ATENÇÃO!", MessageBoxButton.OK, MessageBoxImage.Information);
                                        cepEmpTextBox.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    ruaEmpTextBox.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    //complementoTextBox.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    bairroEmpTextBox.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    cidadeEmpTextBox.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    estadoEmpTextBox.Text = valor[1];
                                }

                                cont++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possível acessar a INTERNET. Por favor preencha os dados MANUALMENTE. \n\n Ou aguarde o reestabelecimento a conexão com a INTERNET.", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        public static int IsConnected()
        {
            int fail;

            System.Uri Url = new System.Uri("http://www.microsoft.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                fail = 0; //consegue conexão à internet
                return fail;
            }

            catch
            {
                WebReq = null;
                fail = 1; //falhou a conexão à internet
                return fail;
            }
        }


        public bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        private void cpfTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.Key == Key.Back || e.Key == Key.Delete)
            {
                try
                {
                    string valorString = txt.Text.Trim();
                    if (valorString.Length == 4)  // 000.
                    {
                        txt.Text = valorString.Substring(0, 2); // 00
                        e.Handled = true;
                        txt.SelectionStart = txt.Text.Length + 1;
                    }
                    else if (valorString.Length == 8)  // 000.000.
                    {
                        txt.Text = valorString.Substring(0, 6); // 000.00
                        e.Handled = true;
                        txt.SelectionStart = txt.Text.Length + 1;
                    }
                    else if (valorString.Length == 12)  // 000.000.000-
                    {
                        txt.Text = valorString.Substring(0, 10); // 000.000.00
                        e.Handled = true;
                        txt.SelectionStart = txt.Text.Length + 1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n\n\n" + ex);
                }
            }
        }
        private void cpfTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, apenas números");
                this.Focus();
            }
        }
        private void cpfTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            string valorString = cpfTextBox.Text.Trim();
            if (valorString.Length == 3)  // 000
            {
                cpfTextBox.Text = valorString + ".";
                cpfTextBox.SelectionStart = cpfTextBox.Text.Length + 1;
            }
            else if (valorString.Length == 7)  // 000.000
            {
                cpfTextBox.Text = valorString + ".";
                cpfTextBox.SelectionStart = cpfTextBox.Text.Length + 1;
            }
            else if (valorString.Length == 11)
            {
                cpfTextBox.Text = valorString + "-";   // 000.000.000
                cpfTextBox.SelectionStart = cpfTextBox.Text.Length + 1;
            }
            else if (valorString.Length > 14)  // 000.000.000-00
            {
                MessageBox.Show("A quantidade Maxima de digitos já foram inseridos ");
                cpfTextBox.Text = valorString.Substring(0, valorString.Length - 1);
                cpfTextBox.SelectionStart = cpfTextBox.Text.Length + 1;
            }

            if (IsCpf(cpfTextBox.Text))
            {
                cpfTextBox.Foreground = Brushes.Black;
            }
            else
            {
                cpfTextBox.Foreground = Brushes.Red;
            }

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


        private void nascimentoDT_LostFocus(object sender, RoutedEventArgs e)
        {
            DateTime dataConvertida = (DateTime)nascimentoDT.DateTime;
            int dias = (DateTime.Now - dataConvertida).Days;
            int anos = dias / 360;
            int meses = (dias % 360) / 30;
            idadeTextBox.Text = anos + " anos e " + meses + " meses";
        }

        private void DataEmpresaDT_LostFocus(object sender, RoutedEventArgs e)
        {
            if (DataEmpresaDT.DateTime != null)
            {
                DateTime dataConvertida2 = (DateTime)DataEmpresaDT.DateTime;
                int dias2 = (DateTime.Now - dataConvertida2).Days;
                int anos2 = dias2 / 360;
                int meses2 = (dias2 % 360) / 30;
                tempoServicoTextBox.Text = anos2 + " anos e " + meses2 + " meses";
            }
        }




        private void telefone_PreviewImput(object sender, TextCompositionEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            bool approvedDecimalPoint = false;

            if (e.Text == ")" || e.Text == "(" || e.Text == "-")
            {
                if (!((System.Windows.Controls.TextBox)sender).Text.Contains("("))
                    approvedDecimalPoint = true;
                else if (!((System.Windows.Controls.TextBox)sender).Text.Contains(")"))
                    approvedDecimalPoint = true;
                else if (!((System.Windows.Controls.TextBox)sender).Text.Contains("-"))
                    approvedDecimalPoint = true;
            }

            if (!(char.IsDigit(e.Text, e.Text.Length - 1) || approvedDecimalPoint))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, apenas números, () e - ex: (21)96585-8965");
                this.Focus();
            }
            if (txt.Text.Length > 17) //(21) 00000-0000
            {
                e.Handled = true;
                MessageBox.Show("A quantidade Maxima de 17 digitos já foram inseridos ");
            }
        }



    } //Fim Class
}
